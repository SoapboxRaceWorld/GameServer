// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 11:59 PM.

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreLibraries.GameUtilities;
using SBRW.GameServer.Attrib.Gen;
using Victory.Service.Objects.Event;

namespace SBRW.GameServer.Services
{
    public class CarClassesService : ICarClassesService
    {
        private readonly IAttribService _attribService;
        private List<CarClass> _classes = new List<CarClass>();

        public CarClassesService(IAttribService attribService)
        {
            _attribService = attribService;
            UpdateClasses();
        }

        public async Task<List<CarClass>> GetCarClasses()
        {
            return await Task.FromResult(this._classes);
        }

        private void UpdateClasses()
        {
            IEnumerable<WORLD_gameplay> carClassCollections =
                from collection in _attribService.FindCollections("gameplay/baseelement/serveritems/car_class/.*")
                let w = new WORLD_gameplay(collection)
                where w.HasField(WORLD_gameplay.Name_FEIconLocked)
                select w;

            foreach (var collection in carClassCollections)
            {
                int hash = unchecked((int) VLT32Hasher.Hash(collection.Name()));

                _classes.Add(new CarClass
                {
                    CarClassHash = hash,
                    MinRating = collection.CarClassMinRating(),
                    MaxRating = collection.CarClassMaxRating()
                });
            }
        }
    }
}