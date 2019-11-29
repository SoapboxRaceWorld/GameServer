// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 1:08 PM.

using System.Threading.Tasks;
using SBRW.Data.Entities;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Services
{
    public interface ISessionService
    {
        Task<UserInfo> GetPermanentSession(AppUser user, string token);
    }
}