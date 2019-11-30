// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 4:39 PM.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SBRW.Data;
using SBRW.Data.Entities;
using Victory.Service.Objects;

namespace SBRW.GameServer.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly GameDbContext _dbContext;

        public PersonaService(GameDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AppPersona> FindPersonaById(int personaId)
        {
            AppPersona persona = await _dbContext.Personas.FindAsync(personaId);

            if (persona == null)
            {
                throw new ArgumentException("Cannot find persona with ID " + personaId);
            }

            return persona;
        }

        public ProfileData GetPersonaInfo(AppPersona persona)
        {
            return new ProfileData
            {
                Motto = persona.Motto,
                Badges = new List<BadgePacket>(),
                Cash = persona.Cash,
                IconIndex = persona.IconIndex,
                PersonaId = persona.ID,
                Level = persona.Level,
                Rep = persona.Reputation,
                RepAtCurrentLevel = (int) persona.ReputationAtLevel,
                Score = persona.Score,
                Name = persona.Name
            };
        }
    }
}