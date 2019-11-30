// This file is part of SBRW.GameServer by heyitsleo.
// 
// Created: 11/30/2019 @ 1:30 PM.

using System;

namespace SBRW.GameServer.Session
{
    [Serializable]
    public class UserSession
    {
        public int UserID { get; set; }
        public int PersonaID { get; set; }

        public UserSession() { }
    }
}