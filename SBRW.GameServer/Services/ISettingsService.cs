// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 2:29 PM.

using SBRW.Data.Entities;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.Social;

namespace SBRW.GameServer.Services
{
    public interface ISettingsService
    {
        User_Settings FetchClientSettings(AppUser user);

        SocialSettings FetchSocialSettings(AppUser user);

        void SaveSocialSettings(SocialSettings settings);
    }
}