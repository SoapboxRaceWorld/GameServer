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
    [Route("nfsw/Engine.svc/personas")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class PersonasController : ControllerBase
    {
        [HttpGet("{personaId:int}/{language}")]
        public CarSlotInfoTrans GetPersonaCarSlots(int personaId, string language)
        {
            return new CarSlotInfoTrans
            {
                CarsOwnedByPersona = new List<OwnedCarTrans>(),
                DefaultOwnedCarIndex = 0,
                ObtainableSlots = new List<ProductTrans>(),
                OwnedCarSlotsCount = 0
            };
        }
    }
}