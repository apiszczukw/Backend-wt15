﻿using Backend_wt15.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_wt15.DAL
{
    public class SklepContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public SklepContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new { Id=1, Name="pomidor", Price=7.9f },
                new { Id=2, Name="ziemniaki", Price=2.9f },
                new { Id=3, Name="ogorek", Price=9.9f },
                new { Id=4, Name="kalafior", Price=11.9f },
                new { Id=5, Name="brokuł", Price=7.5f },
                new { Id=6, Name="cukinia", Price=8.2f }
                );
        }
    }
}
