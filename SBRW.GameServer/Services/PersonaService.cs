// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 4:39 PM.

using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<PersonaBase>> GetPersonaBaseFromList(List<long> personaIds)
        {
            List<PersonaBase> personas = new List<PersonaBase>();

            foreach (var personaId in personaIds.Select(Convert.ToInt32))
            {
                AppPersona persona = await FindPersonaById(personaId);
                personas.Add(ConvertPersonaEntityToPersonaBase(persona));
            }

            return personas;
        }

        private PersonaBase ConvertPersonaEntityToPersonaBase(AppPersona persona) => new PersonaBase
        {
            Motto = persona.Motto,
            Badges = new List<BadgePacket>(),
            IconIndex = persona.IconIndex,
            Level = persona.Level,
            PersonaId = persona.ID,
            Presence = 1,
            Name = persona.Name,
            Score = persona.Score,
            UserId = persona.User.Id
        };
    }
}