using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SBRW.Data.Entities;
using Victory.TransferObjects.DriverPersona;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class FriendsController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public FriendsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// Obtains the friends list for the current user.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getfriendlistfromuserid")]
        public async Task<PersonaFriendsList> GetFriendsList()
        {
            AppUser user = await _userManager.GetUserAsync(HttpContext.User);

            // TODO: do something with user

            return new PersonaFriendsList
            {
                friendPersona = new List<FriendPersona>()
            };
        }
    }
}