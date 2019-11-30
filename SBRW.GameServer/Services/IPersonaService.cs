// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 4:38 PM.

using System.Threading.Tasks;
using SBRW.Data.Entities;
using Victory.Service.Objects;

namespace SBRW.GameServer.Services
{
    public interface IPersonaService
    {
        Task<AppPersona> FindPersonaById(int personaId);

        ProfileData GetPersonaInfo(AppPersona persona);
    }
}