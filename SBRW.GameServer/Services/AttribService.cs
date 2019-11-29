// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 3:08 PM.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CoreLibraries.ModuleSystem;
using Microsoft.Extensions.Logging;
using SBRW.GameServer.Services.Attrib;
using VaultLib.Core.Data;
using VaultLib.Core.DB;
using VaultLib.Core.Hashing;
using VaultLib.Core.Loading;

namespace SBRW.GameServer.Services
{
    public class AttribService : IAttribService
    {
        private readonly ILogger<AttribService> _logger;

        private readonly GameplayVault _gameplayVault;
        private readonly ModuleLoader _moduleLoader;

        private Database _database;

        public AttribService(ILogger<AttribService> logger,
            GameplayVault gameplayVault,
            ModuleLoader moduleLoader)
        {
            _logger = logger;
            _gameplayVault = gameplayVault;
            _moduleLoader = moduleLoader;

            HashManager.LoadDictionary(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\hashes.txt"));
        }

        public void LoadAttribData()
        {
            _logger.LogDebug("Loading VLT data");

            _database = new Database("WORLD");

            LoadMainFiles();
            LoadGameplayFiles();

            _database.CompleteLoad();

            foreach (var carClassCollection in FindCollections("gameplay/baseelement/serveritems/car_class/.*"))
            {
                _logger.LogDebug("CarClass {name} ({fullPath})", carClassCollection.Name, carClassCollection.FullPath);
            }
        }

        public IEnumerable<VLTCollection> FindCollections(string regexPattern)
        {
            Regex regex = new Regex(regexPattern, RegexOptions.IgnoreCase);

            return _database.RowManager.EnumerateFlattenedCollections().Where(c => regex.IsMatch(c.FullPath));
        }

        private void LoadGameplayFiles()
        {
            foreach (var file in Directory.GetFiles(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data\gc.vaults"), "*.bin",
                SearchOption.TopDirectoryOnly))
            {
                //_logger.LogInformation("Loading {path}", file);
                using BinaryReader br = new BinaryReader(File.OpenRead(file));
                _gameplayVault.Load(br, _database, new PackLoadingOptions());
            }
        }

        private void LoadMainFiles()
        {
            foreach (var file in Directory.GetFiles(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"data"), "*.bin",
                SearchOption.TopDirectoryOnly))
            {
                StandardVaultPack svp = new StandardVaultPack();

                _logger.LogInformation("Loading {path}", file);
                using BinaryReader br = new BinaryReader(File.OpenRead(file));
                svp.Load(br, _database, new PackLoadingOptions());
            }
        }
    }
}