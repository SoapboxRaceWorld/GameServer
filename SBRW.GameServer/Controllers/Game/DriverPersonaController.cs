using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SBRW.GameServer.Services;
using Victory.Service.Objects;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/DriverPersona")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class DriverPersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;

        public DriverPersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet("GetExpLevelPointsMap")]
        public async Task<List<int>> GetExpLevelPointsMap()
        {
            return await Task.FromResult(new List<int>
            {
                100, 975, 2025
            });
        }

        [HttpGet("GetPersonaInfo")]
        public async Task<ProfileData> GetPersonaInfo([FromQuery] int personaId)
        {
            return _personaService.GetPersonaInfo(await _personaService.FindPersonaById(personaId));
        }
    }
}