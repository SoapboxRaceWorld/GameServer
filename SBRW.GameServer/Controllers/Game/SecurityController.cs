using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SBRW.Data.Entities;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/security")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class SecurityController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public SecurityController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("fraudConfig")]
        public async Task<FraudConfig> GetFraudConfig()
        {
            AppUser user = await _userManager.GetUserAsync(User);

            return new FraudConfig
            {
                enabledBitField = 12,
                gameFileFreq = 1000000,
                moduleFreq = 360000,
                startUpFreq = 1000000,
                userID = user.Id
            };
        }
    }
}