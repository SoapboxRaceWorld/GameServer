using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Victory.DataLayer.Serialization;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc/[controller]")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Establishes a permanent gameplay session for a client.
        /// </summary>
        /// <param name="data">Identifying information sent by the client.</param>
        /// <returns>A <see cref="UserInfo"/> object with session details.</returns>
        [HttpPost("GetPermanentSession")]
        public UserInfo GetPermanentSession([FromBody] GetPermanentSessionData data)
        {
            return new UserInfo
            {
                defaultPersonaIdx = 0,
                personas = new List<ProfileData>(),
                user = new User
                {
                    fullGameAccess = false,
                    isComplete = false,
                    remoteUserId = 1,
                    securityToken = Request.Headers["securityToken"][0],
                    subscribeMsg = false,
                    userId = 1
                }
            };
        }
    }
}