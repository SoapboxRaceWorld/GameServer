// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 1:13 PM.

using System.Collections.Generic;
using System.Threading.Tasks;
using SBRW.Data.Entities;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Services
{
    public class SessionService : ISessionService
    {
        public async Task<UserInfo> GetPermanentSession(AppUser user, string token)
        {
            return new UserInfo
            {
                personas = new List<ProfileData>
                {
                    new ProfileData
                    {
                        PersonaId = 101L,
                        Name = "hey",
                        Boost = 1337,
                        Cash = 1337,
                        Level = 1,
                        Rep = 10,
                        RepAtCurrentLevel = 10,
                        IconIndex = 5,
                        Motto = "me gusta el pan",
                        PercentToLevel = 0.1f,
                        Rating = 420
                    }
                },
                user = new User
                {
                    securityToken = token,
                    fullGameAccess = false,
                    isComplete = false,
                    userId = user.Id,
                    remoteUserId = user.Id
                }
            };
        }
    }
}