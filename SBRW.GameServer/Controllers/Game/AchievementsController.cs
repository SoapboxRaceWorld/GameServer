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
using SBRW.GameServer.Services;
using Victory.Service.Objects;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/achievements")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class AchievementsController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        private readonly ISessionService _sessionService;

        private readonly UserManager<AppUser> _userManager;
            
        public AchievementsController(IPersonaService personaService, ISessionService sessionService,
            UserManager<AppUser> userManager)
        {
            _personaService = personaService;
            _sessionService = sessionService;
            _userManager = userManager;
        }

        [HttpGet("loadall")]
        public async Task<IActionResult> LoadAllAchievements()
        {
            AppUser user = await _userManager.GetUserAsync(User);
            int currentPersonaId = await _sessionService.GetCurrentPersonaId(user);

            if (currentPersonaId == 0)
            {
                return Unauthorized();
            }

            return Ok(new AchievementsPacket
            {
                PersonaId = currentPersonaId,
                Badges = new List<BadgeDefinitionPacket>(),
                Definitions = new List<AchievementDefinitionPacket>()
            });
        }
    }
}