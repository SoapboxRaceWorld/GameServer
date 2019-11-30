using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SBRW.GameServer.Services;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
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

        [HttpGet("{personaId:int}/carslots")]
        public async Task<CarSlotInfoTrans> GetPersonaCarSlots(int personaId, [FromQuery] string language)
        {
            return await _personaCarService.GetCarSlots(personaId);
        }

        [HttpGet("{personaId:int}/defaultcar")]
        public async Task<OwnedCarTrans> GetPersonaDefaultCar(int personaId)
        {
            return await _personaCarService.GetDefaultCar(personaId);
        }

        [HttpGet("inventory/objects")]
        public async Task<InventoryTrans> GetPersonaInventory()
        {
            return await Task.FromResult(new InventoryTrans
            {
                PerformancePartsCapacity = 1000,
                SkillModPartsCapacity = 1000,
                VisualPartsCapacity = 1000,
                InventoryItems = new List<InventoryItemTrans>
                {
                    new InventoryItemTrans
                    {
                        EntitlementTag = "t0_gearhead_transmission_elite_uncommonrarity",
                        Hash = -1461502897,
                        InventoryId = 1,
                        ProductId = "SRV-PERF131",
                        RemainingUseCount = 1,
                        Status = "ACTIVE",
                        VirtualItemType = "performancepart",
                        ResellPrice = 1337.42069
                    }
                }
            });
        }
    }
}