using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization.Gift;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/Gifts")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class GiftsController : ControllerBase
    {
        [HttpPost("GetAndTriggerAvailableLevelGifts")]
        public async Task<List<LevelGiftDefinition>> GetAndTriggerAvailableLevelGifts()
        {
            return await Task.FromResult(new List<LevelGiftDefinition>
            {
                //new LevelGiftDefinition {Boost = 5000, Level = 1, LevelGiftId = 1}
            });
        }
    }
}