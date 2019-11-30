// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 1:13 PM.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SBRW.Data;
using SBRW.Data.Entities;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Services
{
    public class SessionService : ISessionService
    {
        private readonly GameDbContext _dbContext;

        public SessionService(GameDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserInfo> GetPermanentSession(AppUser user, string token)
        {
            await _dbContext.Entry(user)
                .Collection(u => u.Personas)
                .LoadAsync();
            return new UserInfo
            {
                personas = new List<ProfileData>(user.Personas.Select(ConvertPersonaToProfile)),
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

        private ProfileData ConvertPersonaToProfile(AppPersona persona)
        {
            return new ProfileData
            {
                Name = persona.Name,
                Boost = persona.Boost,
                Cash = persona.Cash,
                ccar = new List<PersonaCCar>(),
                IconIndex = persona.IconIndex,
                Level = persona.Level,
                Motto = persona.Motto,
                PercentToLevel = 0,
                PersonaId = persona.ID,
                Rating = persona.Rating
            };
        }
    }
}