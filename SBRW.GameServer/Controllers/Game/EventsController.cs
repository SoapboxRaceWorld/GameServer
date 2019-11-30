using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization.Event;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/events")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class EventsController : ControllerBase
    {
        [HttpGet("availableatlevel")]
        public async Task<EventsPacket> GetAllAvailableAtLevel()
        {
            return await Task.FromResult(new EventsPacket
            {
                Events = new List<EventDefinition>()
            });
        }

        [HttpGet("gettreasurehunteventsession")]
        public async Task<TreasureHuntEventSession> GetTreasureHuntEventSession()
        {
            return await Task.FromResult(new TreasureHuntEventSession
            {
                CoinsCollected = 0,
                IsStreakBroken = false,
                NumCoins = 15,
                Seed = 1299378674,
                Streak = 128
            });
        }
    }
}