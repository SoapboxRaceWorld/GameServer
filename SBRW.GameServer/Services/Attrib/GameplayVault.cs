// This file is part of GameDataService by heyitsleo.
// 
// Created: 11/27/2019 @ 5:24 PM.

using System;
using System.IO;
using CoreLibraries.IO;
using VaultLib.Core;
using VaultLib.Core.DB;
using VaultLib.Core.Loading;

namespace SBRW.GameServer.Services.Attrib
{
    public class GameplayVault : IVaultPack
    {
        public void Load(BinaryReader br, Database database, PackLoadingOptions loadingOptions = null)
        {
            string name = new string(br.ReadChars(0x2C)).Trim('\0');

            int binOffset = br.ReadInt32();
            int binSize = br.ReadInt32();
            int vltOffset = br.ReadInt32();
            int vltSize = br.ReadInt32();
            int fileSize = br.ReadInt32();

            if (fileSize != br.BaseStream.Length)
            {
                throw new InvalidDataException("Corrupted file");
            }

            Vault vault = new Vault(name);
            DatabaseLoadedFile file = new DatabaseLoadedFile();
            ByteOrder byteOrder = loadingOptions?.ByteOrder ?? ByteOrder.Little;
            br.BaseStream.Seek(binOffset, SeekOrigin.Begin);
            byte[] binBuffer = new byte[binSize];
            if (br.Read(binBuffer, 0, binBuffer.Length) != binBuffer.Length)
                throw new Exception($"Failed to read {binBuffer.Length} bytes of BIN data");
            br.BaseStream.Seek(vltOffset, SeekOrigin.Begin);
            byte[] vltBuffer = new byte[vltSize];
            if (br.Read(vltBuffer, 0, vltBuffer.Length) != vltBuffer.Length)
                throw new Exception($"Failed to read {vltBuffer.Length} bytes of VLT data");
            vault.BinStream = new MemoryStream(binBuffer);
            vault.VltStream = new MemoryStream(vltBuffer);
            using (VaultLoadingWrapper loadingWrapper = new VaultLoadingWrapper(vault, byteOrder))
                database.LoadVault(file, vault, loadingWrapper);
            database.LoadFile(file);
        }
    }
}