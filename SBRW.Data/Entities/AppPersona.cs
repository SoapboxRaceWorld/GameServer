// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/28/2019 @ 11:28 AM.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBRW.Data.Entities
{
    /// <summary>
    /// A persona is an individual "driver" profile on an account.
    /// A persona has cars, inventory items, currency amounts, and other such things. 
    /// </summary>
    [Table("personas")]
    public class AppPersona
    {
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// The name of the persona.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The amount of cash the persona has.
        /// </summary>
        public double Cash { get; set; }

        /// <summary>
        /// The amount of "SpeedBoost" the persona has.
        /// </summary>
        public double Boost { get; set; }

        /// <summary>
        /// The persona's avatar ID (zero-based index)
        /// </summary>
        public int IconIndex { get; set; }

        /// <summary>
        /// The persona's current status message, or motto
        /// </summary>
        public string Motto { get; set; }

        /// <summary>
        /// The progression level the persona is at
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The persona's "reputation" - the total amount of XP they have gathered in their career
        /// </summary>
        public double Reputation { get; set; }

        /// <summary>
        /// The persona's "reputation" that they have gathered at their current level
        /// </summary>
        public double ReputationAtLevel { get; set; }

        /// <summary>
        /// Skill rating?
        /// </summary>
        /// <remarks>We never really did anything with this before. Probably a matchmaking thing?</remarks>
        public double Rating { get; set; }

        /// <summary>
        /// The persona's "driver score" - gained through achievement completion.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// The user that the persona is associated with.
        /// </summary>
        public AppUser User { get; set; }
    }
}