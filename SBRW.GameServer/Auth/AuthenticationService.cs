using Microsoft.AspNetCore.Identity;
using SBRW.Data.Entities;

namespace SBRW.GameServer.Auth
{
    /// <summary>
    /// Manages user log-ins and tokens
    /// </summary>
    public class AuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthenticationService(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        
        
    }
}