using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szkolny_Dziennik.BazaDanych.Models;

namespace Szkolny_Dziennik.BazaDanych.Context
{
    class StudentsDataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Database.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Student> Students { get; set; } 
        public DbSet<SchoolClass> SchoolClasses { get; set; }
    }
}
