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
    [Route("nfsw/Engine.svc/Reporting")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class ReportingController : ControllerBase
    {
        [HttpPost("SendHardwareInfo")]
        public IActionResult SendHardwareInfo([FromBody] HardwareInfo hardwareInfo)
        {
            return Ok();
        }

        [HttpPost("SendUserSettings")]
        public IActionResult SendUserSettings([FromBody] UserSettings userSettings)
        {
            return Ok();
        }
    }
}