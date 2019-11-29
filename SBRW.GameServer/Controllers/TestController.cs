using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize(Policy = "SoapServicePlayer")]
    public class TestController : ControllerBase
    {
        [HttpGet("inventory")]
        [Produces(MediaTypeNames.Application.Xml)]
        public IActionResult TestInventory()
        {
            return Ok(new InventoryTrans
            {
                PerformancePartsCapacity = 100,
                SkillModPartsCapacity = 100,
                VisualPartsCapacity = 100,
                InventoryItems = new List<InventoryItemTrans>
                {
                    new InventoryItemTrans
                    {
                        EntitlementTag = "CoolCoolCoolCool",
                        ExpirationDate = DateTimeOffset.Now.AddDays(7).UtcDateTime,
                        Hash = 1337,
                        InventoryId = 1,
                        ProductId = "MEMES",
                        RemainingUseCount = 1337,
                        ResellPrice = 420.69,
                        VirtualItemType = "meme",
                        Status = "ACTIVE i guess",
                        StringHash = "0x00000539"
                    }
                }
            });
        }
    }
}