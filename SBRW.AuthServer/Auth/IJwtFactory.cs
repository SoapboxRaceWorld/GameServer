// This file is part of SBRW.AuthServer by heyitsleo.
// 
// Created: 11/29/2019 @ 10:42 AM.

using System.Security.Claims;
using System.Threading.Tasks;

namespace SBRW.AuthServer.Auth
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedToken(string email, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string email, string id);
    }
}