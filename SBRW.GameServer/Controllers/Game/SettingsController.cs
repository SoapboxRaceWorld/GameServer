using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SBRW.Data.Entities;
using SBRW.GameServer.Services;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Controllers.Game
{
    [Route("nfsw/Engine.svc")]
    [ApiController]
    [Consumes(MediaTypeNames.Text.Xml)]
    [Produces(MediaTypeNames.Application.Xml)]
    [Authorize(Policy = "SoapServicePlayer")]
    public class SettingsController : ControllerBase
    {
        private readonly UserManager<AppUser> _manager;
        private readonly ISettingsService _settingsService;

        public SettingsController(UserManager<AppUser> manager, ISettingsService settingsService)
        {
            _manager = manager;
            _settingsService = settingsService;
        }

        /// <summary>
        /// Returns system-provided settings for the client.
        /// </summary>
        /// <returns>The settings for the client, in the form of a <see cref="User_Settings"/> object.</returns>
        [HttpGet("getusersettings")]
        public async Task<User_Settings> GetUserSettings()
        {
            AppUser user = await _manager.GetUserAsync(User);

            return await Task.FromResult(_settingsService.FetchClientSettings(user));
        }
    }
}