// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 1:13 PM.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using SBRW.Data;
using SBRW.Data.Entities;
using SBRW.GameServer.Session;
using SBRW.GameServer.Utils;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Services
{
    public class SessionService : ISessionService
    {
        private readonly GameDbContext _dbContext;
        private readonly IDistributedCache _distributedCache;

        public SessionService(GameDbContext dbContext, IDistributedCache distributedCache)
        {
            _dbContext = dbContext;
            _distributedCache = distributedCache;
        }

        public async Task<UserInfo> GetPermanentSession(AppUser user, string token)
        {
            // Load personas
            await _dbContext.Entry(user)
                .Collection(u => u.Personas)
                .LoadAsync();
            // Reset session info
            await CreateSession(user);

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

        public async Task SecureLoginPersona(AppUser user, int personaId)
        {
            if (personaId != 0)
            {
                AppPersona persona = await _dbContext.Personas.Include(p => p.User)
                    .FirstOrDefaultAsync(p => p.User.Id == user.Id);

                if (persona == null)
                {
                    throw new ArgumentException($"Persona {personaId} either does not exist or is not available");
                }
            }

            UserSession session = await GetSession(user);
            session.PersonaID = personaId;
            await UpdateSession(user, session);
        }

        public async Task<int> GetCurrentPersonaId(AppUser user)
        {
            UserSession session = await GetSession(user);

            return session.PersonaID;
        }

        public async Task<UserSession> GetSession(AppUser user)
        {
            byte[] data = await _distributedCache.GetAsync(GetSessionKey(user));
            UserSession session;

            if (data == null)
            {
                session = await CreateSession(user);
            }
            else
            {
                session = data.FromByteArray<UserSession>();
            }

            return session;
        }

        private async Task<UserSession> CreateSession(AppUser user)
        {
            UserSession session = new UserSession { UserID = user.Id };
            await UpdateSession(user, session);
            return session;
        }

        public async Task UpdateSession(AppUser user, UserSession session)
        {
            await _distributedCache.SetAsync(GetSessionKey(user), session.ToByteArray(),
                new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(2)
                });
        }

        private string GetSessionKey(AppUser user)
        {
            return "session_" + user.Id;
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

        private async Task RemoveSession(AppUser user)
        {
            await _distributedCache.RemoveAsync(GetSessionKey(user));
        }
    }
}