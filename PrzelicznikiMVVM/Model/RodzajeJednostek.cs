using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzelicznikiMVVM.BazaDanych.Modele
{
    class RodzajeJednostek
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Jednostki> Units { get; set; }
    }
}
