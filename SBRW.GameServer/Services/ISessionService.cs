// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 1:08 PM.

using System.Threading.Tasks;
using SBRW.Data.Entities;
using SBRW.GameServer.Session;
using Victory.TransferObjects.User;

namespace SBRW.GameServer.Services
{
    public interface ISessionService
    {
        /// <summary>
        /// Creates a <see cref="UserInfo"/> object with information about the given <see cref="AppUser"/>.
        /// This is sent back to the game client.
        /// </summary>
        /// <param name="user">The <see cref="AppUser"/> to get info for</param>
        /// <param name="token">The authentication token used to log in.</param>
        /// <returns>A <see cref="UserInfo"/> object filled with relevant information.</returns>
        Task<UserInfo> GetPermanentSession(AppUser user, string token);

        /// <summary>
        /// Sets the current persona ID in the given user's session to the given persona ID.
        /// </summary>
        /// <remarks>Enforces access control - this operation is only valid for personas controlled by the user.</remarks>
        /// <param name="user"></param>
        /// <param name="personaId"></param>
        /// <returns></returns>
        Task SecureLoginPersona(AppUser user, int personaId);

        Task<int> GetCurrentPersonaId(AppUser user);

        Task<UserSession> GetSession(AppUser user);

        Task UpdateSession(AppUser user, UserSession session);
    }
}