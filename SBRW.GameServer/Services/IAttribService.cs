// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/29/2019 @ 3:07 PM.

using System.Collections.Generic;
using VaultLib.Core.Data;

namespace SBRW.GameServer.Services
{
    public interface IAttribService
    {
        void LoadAttribData();

        IEnumerable<VLTCollection> FindCollections(string regexPattern);
    }
}