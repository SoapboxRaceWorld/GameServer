using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;

namespace SBRW.GameServer.Middleware
{
    /// <summary>
    /// The "Blackbox Middleware" does all the weird things to the server response
    /// that the game needs in order to function properly. No big deal.
    /// </summary>
    public class BlackboxMiddleware
    {
        private readonly ILogger<BlackboxMiddleware> _logger;

        private readonly RequestDelegate _next;

        public BlackboxMiddleware(RequestDelegate next, ILogger<BlackboxMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Called upon invocation of the middleware.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            // Disables chunked encoding. The game doesn't like that.
            context.Features.Get<IHttpResponseBodyFeature>()?.DisableBuffering();
            
            // Hacky way of forcing certain headers to be set.
            // Unfortunately, we can't do this any other way. 
            // This is the only way to do it that won't result in "Headers are readonly, response has already started".
            context.Response.OnStarting(state =>
            {
                var httpContext = (HttpContext) state;
                
                httpContext.Response.Headers.Add("Content-Encoding", "gzip");
                httpContext.Response.Headers.Add("Connection", "close"); // The game doesn't like anything else...
                return Task.FromResult(0);
            }, context);
            
            // Here we start doing the response compression.
            // Unfortunately, ASP.NET Core forces us to resort to 
            // somewhat ugly methods of manipulating the data.
            var existingBody = context.Response.Body;

            await using var newBody = new MemoryStream();
            context.Response.Body = newBody;

            try
            {
                await _next(context);

                context.Response.Body = existingBody;

                newBody.Seek(0, SeekOrigin.Begin);

                var compressedBody = new MemoryStream();

                await using (var compressedStream = new GZipStream(compressedBody, CompressionLevel.Fastest, true))
                {
                    await newBody.CopyToAsync(compressedStream);
                }

                context.Response.ContentLength = compressedBody.Length;
                await context.Response.Body.WriteAsync(compressedBody.ToArray());
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while processing a request");
            }
        }
    }
}