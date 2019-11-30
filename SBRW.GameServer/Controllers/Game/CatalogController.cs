using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/catalog")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }

        [HttpGet("productsInCategory")]
        public async Task<List<ProductTrans>> GetProductsInCategory([FromQuery] string categoryName,
            [FromQuery] string clientProductType, [FromQuery] string currencyType, [FromQuery] string language)
        {
            _logger.LogDebug(
                "Fetch products in {Category} of type {ProdType} w/ currency {Currency} in language {Lang}",
                categoryName, clientProductType, currencyType, language);
            return await Task.FromResult(new List<ProductTrans>());
        }
    }
}