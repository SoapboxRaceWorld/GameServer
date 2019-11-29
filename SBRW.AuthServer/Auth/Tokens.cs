// This file is part of SBRW.AuthServer by heyitsleo.
// 
// Created: 11/29/2019 @ 10:48 AM.

using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using SBRW.Core.Auth;

namespace SBRW.AuthServer.Auth
{
    public class Tokens
    {
        public static async Task<object> GenerateJwt(ClaimsIdentity identity, IJwtFactory jwtFactory, string email,
            JwtIssuerOptions jwtOptions)
        {
            var response = new
            {
                id = identity.Claims.Single(c => c.Type == "id").Value,
                auth_token = await jwtFactory.GenerateEncodedToken(email, identity),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return response;
            //return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}