using System.Collections.Generic;
using VaultLib.CodeGen;
using VaultLib.Core.Data;

// Generated by VaultLib.CodeGen @ November 30, 2019 4:47:29 AM for game WORLD
namespace SBRW.GameServer.Attrib.Gen
{
    public class WORLD_encounters : CollectionWrapperBase {
        #region Field Names
        public const string Name_PresetRide = "PresetRide";
        public const string Name_CollectionName = "CollectionName";
        public const string Name_SpawnTime = "SpawnTime";
        #endregion

        public WORLD_encounters(VLTCollection collection) : base(collection) {}

        #region Getters
        public System.String CollectionName() {
            return GetValue<System.String>("CollectionName");
        }
        public List<System.String> PresetRide() {
            return GetArray<System.String>("PresetRide");
        }
        public System.Single SpawnTime() {
            return GetValue<System.Single>("SpawnTime");
        }
        #endregion

    }
}