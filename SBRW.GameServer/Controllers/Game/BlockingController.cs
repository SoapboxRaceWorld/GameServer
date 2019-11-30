using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization.Social;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class BlockingController : ControllerBase
    {
        [HttpGet("getblockeduserlist")]
        public async Task<List<BasicBlockPlayerInfo>> GetBlockedUserList()
        {
            return await Task.FromResult(new List<BasicBlockPlayerInfo>());
        }

        [HttpGet("getblockersbyusers")]
        public async Task<List<long>> GetBlockersByUsers([FromQuery] int personaId)
        {
            return await Task.FromResult(new List<long>());
        }
    }
}