using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/logging")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class LoggingController : ControllerBase
    {
        [HttpGet("client")]
        public async Task<ClientConfigTrans> GetClientConfig()
        {
            ClientConfigTrans cc = new ClientConfigTrans();
            cc.clientConfigs = new List<ClientConfig>();
            return await Task.FromResult(cc);
        }
    }
}