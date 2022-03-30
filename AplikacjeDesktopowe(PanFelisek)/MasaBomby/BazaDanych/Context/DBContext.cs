using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasaBomby.BazaDanych.Modele;
using Microsoft.EntityFrameworkCore;

namespace MasaBomby.BazaDanych.Context
{
    class ConvertorDbContext : DbContext
    {
        public ConvertorDbContext()
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=ConvertorsDataBase.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Jednostki> Units { get; set; }
        public DbSet<RodzajeJednostek> TypeOfUnits { get; set; }
        public DbSet<Przelicznik> Convertors { get; set; }

    }
}
