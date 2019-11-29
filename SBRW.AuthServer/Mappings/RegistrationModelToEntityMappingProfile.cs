// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/28/2019 @ 11:57 AM.

using AutoMapper;
using SBRW.Data.Entities;
using SBRW.GameServer.Auth;

namespace SBRW.GameServer.Mappings
{
    public class RegistrationModelToEntityMappingProfile : Profile
    {
        public RegistrationModelToEntityMappingProfile()
        {
            CreateMap<RegistrationModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}