// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 12:02 PM.

using SBRW.Data;
using SBRW.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Victory.DataLayer.Serialization;

namespace SBRW.GameServer.Services
{
    public class PersonaCarService : IPersonaCarService
    {
        private readonly GameDbContext _context;

        private readonly IPersonaService _personaService;

        public PersonaCarService(GameDbContext context, IPersonaService personaService)
        {
            _context = context;
            _personaService = personaService;
        }

        public async Task<CarSlotInfoTrans> GetCarSlots(int personaId)
        {
            AppPersona persona = await _personaService.FindPersonaById(personaId);

            await _context.Entry(persona)
                .Collection(p => p.OwnedCars)
                .LoadAsync();

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
            AppPersona persona = await _personaService.FindPersonaById(personaId);

            await _context.Entry(persona)
                .Collection(p => p.OwnedCars)
                .LoadAsync();

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
            cct.CarClassHash = unchecked((int)0xE7CF6958);
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