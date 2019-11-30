// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 11:55 PM.

using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SBRW.GameServer.Services;
using Victory.Service.Objects.Event;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/carclasses")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class CarClassesController : ControllerBase
    {
        private readonly ICarClassesService _carClassesService;

        public CarClassesController(ICarClassesService carClassesService)
        {
            _carClassesService = carClassesService;
        }

        [HttpGet]
        public async Task<List<CarClass>> GetCarClasses()
        {
            return await _carClassesService.GetCarClasses();
        }
    }
}