// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 12:02 PM.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SBRW.Data;
using SBRW.Data.Entities;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Services
{
    public class PersonaCarService : IPersonaCarService
    {
        private readonly GameDbContext _context;

        public PersonaCarService(GameDbContext context)
        {
            _context = context;
        }

        public async Task<CarSlotInfoTrans> GetCarSlots(int personaId)
        {
            AppPersona persona = await _context.Personas.Include(p => p.OwnedCars)
                .ThenInclude(o => o.CustomCar)
                .FirstOrDefaultAsync(p => p.ID == personaId);

            if (persona == null)
            {
                throw new ArgumentException($"Cannot find persona ID {personaId}");
            }

            CarSlotInfoTrans carSlotInfoTrans = new CarSlotInfoTrans();
            carSlotInfoTrans.OwnedCarSlotsCount = persona.OwnedCars.Count;
            carSlotInfoTrans.DefaultOwnedCarIndex = persona.SelectedCarIndex;
            carSlotInfoTrans.CarsOwnedByPersona = new List<OwnedCarTrans>();
            carSlotInfoTrans.ObtainableSlots = new List<ProductTrans>();

            foreach (var personaOwnedCar in persona.OwnedCars)
            {
                carSlotInfoTrans.CarsOwnedByPersona.Add(ConvertOwnedCarToContract(personaOwnedCar));
            }

            return carSlotInfoTrans;
        }

        public async Task<OwnedCarTrans> GetDefaultCar(int personaId)
        {
            AppPersona persona = await _context.Personas.Include(p => p.OwnedCars)
                .ThenInclude(o => o.CustomCar)
                .FirstOrDefaultAsync(p => p.ID == personaId);

            if (persona == null)
            {
                throw new ArgumentException($"Cannot find persona ID {personaId}");
            }

            return ConvertOwnedCarToContract(persona.OwnedCars[persona.SelectedCarIndex]);
        }

        private OwnedCarTrans ConvertOwnedCarToContract(AppOwnedCar personaOwnedCar)
        {
            OwnedCarTrans ownedCarTrans = new OwnedCarTrans();
            ownedCarTrans.Id = personaOwnedCar.ID;
            ownedCarTrans.Durability = personaOwnedCar.Durability;
            ownedCarTrans.Heat = personaOwnedCar.Heat;
            ownedCarTrans.OwnershipType = personaOwnedCar.OwnershipType;
            //ownedCarTrans.ExpirationDate = personaOwnedCar.ExpirationDate?.LocalDateTime ?? null;
            if (personaOwnedCar.ExpirationDate.HasValue)
            {
                ownedCarTrans.ExpirationDate = personaOwnedCar.ExpirationDate.Value.LocalDateTime;
            }

            CustomCarTrans cct = new CustomCarTrans();
            cct.Id = personaOwnedCar.CustomCar.ID;
            cct.BaseCar = personaOwnedCar.CustomCar.BaseCarHash;
            cct.PhysicsProfileHash = personaOwnedCar.CustomCar.PhysicsProfileHash;
            cct.CarClassHash = unchecked((int) 0xE7CF6958);
            cct.Paints = new List<CustomPaintTrans>();
            cct.VisualParts = new List<VisualPartTrans>();
            cct.Rating = 420;
            cct.Vinyls = new List<CustomVinylTrans>();
            cct.PerformanceParts = new List<PerformancePartTrans>();
            cct.SkillModParts = new List<SkillModPartTrans>();
            cct.SkillModSlotCount = 5;
            cct.ResalePrice = personaOwnedCar.CustomCar.ResalePrice;

            ownedCarTrans.CustomCar = cct;

            return ownedCarTrans;
        }
    }
}