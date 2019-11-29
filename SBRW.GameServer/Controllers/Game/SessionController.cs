using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Victory.TransferObjects.Session;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/Session")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class SessionController : ControllerBase
    {
        [HttpGet("GetChatInfo")]
        public async Task<chatServer> GetChatInfo()
        {
            return await Task.FromResult(new chatServer
            {
                ip = "127.0.0.1",
                port = 5222,
                prefix = "nfsw",
                Rooms = new List<chatRoom>
                {
                    new chatRoom
                    {
                        channelCount = 1,
                        longName = "TXT_CHAT_LANG_ENGLISH",
                        shortName = "EN"
                    }
                }
            });
        }
    }
}