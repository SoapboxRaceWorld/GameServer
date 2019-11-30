using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
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