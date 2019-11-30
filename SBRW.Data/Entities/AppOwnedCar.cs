// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/30/2019 @ 11:15 AM.

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBRW.Data.Entities
{
    /// <summary>
    /// An owned car is the container for a car belonging to a persona.
    /// </summary>
    [Table("owned_cars")]
    public class AppOwnedCar
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string OwnershipType { get; set; }

        [Required]
        public float Heat { get; set; }

        public DateTimeOffset? ExpirationDate { get; set; }

        [Required]
        public int Durability { get; set; }

        public AppPersona Persona { get; set; }

        public AppCustomCar CustomCar { get; set; }
    }
}