// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 2:33 PM.

using System.Collections.Generic;
using SBRW.Data.Entities;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.Social;

namespace SBRW.GameServer.Services
{
    public class SettingsService : ISettingsService
    {
        public User_Settings FetchClientSettings(AppUser user)
        {
            return new User_Settings
            {
                userId = user.Id,
                activatedHolidaySceneryGroups = new List<string>(),
                disactivatedHolidaySceneryGroups = new List<string>(),
                MaxCarCacheSize = 1200,
                CarCacheAgeLimit = 600,
                IsRaceNowEnabled = true,
                MinRaceNowLevel = 1,
                VoipAvailable = true,
                activeHolidayIds = new List<long>(),
                firstTimeLogin = false,
                maxLevel = 1,
                starterPackApplied = true
            };
        }

        public SocialSettings FetchSocialSettings(AppUser user)
        {
            return new SocialSettings
            {
                AppearOffline = true,
                DeclineGroupInvite = 1,
                DeclineIncommingFriendRequests = true,
                DeclinePrivateInvite = 1,
                HideOfflineFriends = true,
                ShowNewsOnSignIn = true,
                ShowOnlyPlayersInSameChatChannel = true
            };
        }

        public void SaveSocialSettings(SocialSettings settings)
        {
            throw new System.NotImplementedException();
        }
    }
}