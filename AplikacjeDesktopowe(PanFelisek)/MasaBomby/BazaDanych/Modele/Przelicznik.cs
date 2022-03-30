using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasaBomby.BazaDanych.Modele
{
    class Przelicznik
    {
        public int Id { get; set; }

        public double Multiplier { get; set; }

        public int UnitFromId { get; set; }
        public Jednostki UnitFrom { get; set; }
        public int UnitToId { get; set; }
        public Jednostki UnitTo { get; set; }

    }
}
