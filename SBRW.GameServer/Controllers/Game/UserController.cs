using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SBRW.Data.Entities;
using SBRW.GameServer.Services;
using Victory.DataLayer.Serialization;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/[controller]")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _manager;

        private readonly ISessionService _sessionService;

        public UserController(UserManager<AppUser> manager, ISessionService sessionService)
        {
            _manager = manager;
            _sessionService = sessionService;
        }

        /// <summary>
        /// Establishes a permanent gameplay session for a client.
        /// </summary>
        /// <param name="data">Identifying information sent by the client.</param>
        /// <returns>A <see cref="UserInfo"/> object with session details.</returns>
        [HttpPost("GetPermanentSession")]
        public async Task<UserInfo> GetPermanentSession([FromBody] GetPermanentSessionData data)
        {
            // we are not going to change tokens because it'll just make things more complicated
            string token = await HttpContext.GetTokenAsync("access_token");
            AppUser user = await _manager.GetUserAsync(User);

            return await _sessionService.GetPermanentSession(user, token);
        }
    }
}