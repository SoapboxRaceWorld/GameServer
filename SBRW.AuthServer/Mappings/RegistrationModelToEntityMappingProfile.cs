// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/28/2019 @ 11:57 AM.

using AutoMapper;
using SBRW.AuthServer.Auth;
using SBRW.Data.Entities;

namespace SBRW.AuthServer.Mappings
{
    public class RegistrationModelToEntityMappingProfile : Profile
    {
        public RegistrationModelToEntityMappingProfile()
        {
            CreateMap<RegistrationModel, AppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}