// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/27/2019 @ 10:14 PM.

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SBRW.Data.Entities
{
    /// <summary>
    /// A User entity represents a registered account on a server.
    /// </summary>
    [Table("users")]
    public class AppUser : IdentityUser
    {
        /// <summary>
        /// The <see cref="AppPersona"/> entities associated with the user.
        /// </summary>
        public List<AppPersona> Personas { get; set; }
    }
}