using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SBRW.GameServer.Services;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/personas")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class PersonasController : ControllerBase
    {
        private readonly IPersonaCarService _personaCarService;

        public PersonasController(IPersonaCarService personaCarService)
        {
            _personaCarService = personaCarService;
        }

        [HttpGet("{personaId:int}/{language}")]
        public async Task<CarSlotInfoTrans> GetPersonaCarSlots(int personaId, string language)
        {
            return await _personaCarService.GetCarSlots(personaId);
        }
    }
}