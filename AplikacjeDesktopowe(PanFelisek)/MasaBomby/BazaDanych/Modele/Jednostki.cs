using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasaBomby.BazaDanych.Modele
{
    class Jednostki
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string CharRepresentation { get; set; }

        public int RodzajeJednostekId { get; set; }
        public RodzajeJednostek RodzajeJednostek { get; set; }
    }
}
