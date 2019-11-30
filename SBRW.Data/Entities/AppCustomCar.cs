// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/30/2019 @ 11:20 AM.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SBRW.Data.Entities
{
    [Table("custom_car")]
    public class AppCustomCar
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int ResalePrice { get; set; }

        public float Rating { get; set; }

        public int BaseCarHash { get; set; }

        public int PhysicsProfileHash { get; set; }

        public int OwnedCarId { get; set; }
        public AppOwnedCar OwnedCar { get; set; }
    }
}