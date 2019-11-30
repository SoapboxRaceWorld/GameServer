// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 11:56 AM.

using System.Threading.Tasks;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Services
{
    public interface IPersonaCarService
    {
        Task<CarSlotInfoTrans> GetCarSlots(int personaId);
    }
}