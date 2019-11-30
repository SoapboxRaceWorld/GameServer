// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 11:58 PM.

using System.Collections.Generic;
using System.Threading.Tasks;
using Victory.Service.Objects.Event;

namespace SBRW.GameServer.Services
{
    public interface ICarClassesService
    {
        Task<List<CarClass>> GetCarClasses();
    }
}