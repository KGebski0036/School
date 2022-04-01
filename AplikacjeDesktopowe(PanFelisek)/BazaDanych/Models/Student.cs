using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szkolny_Dziennik.BazaDanych.Models
{
    class Student
    {
        public int Id { set; get; }

        public string Name { set; get; }
        public string SurName { set; get; }
        public int YearOfBirth { set; get; }

        public int SchoolClassId { set; get; }
        public SchoolClass Schoolclass { set; get; }
    }
}
