// This file is part of SBRW.Data by heyitsleo.
// 
// Created: 11/27/2019 @ 10:13 PM.

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SBRW.Data.Entities;

namespace SBRW.Data
{
    public class GameDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public GameDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppPersona>()
                .HasIndex(p => p.Name)
                .IsUnique();
        }
    }
}