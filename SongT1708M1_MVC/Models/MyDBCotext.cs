﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SongT1708M1_MVC.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<SongCategory> SongCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SongT1708M1_MVC;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(sc => new { sc.SongId, sc.CategoryId });
        }
    }
}
