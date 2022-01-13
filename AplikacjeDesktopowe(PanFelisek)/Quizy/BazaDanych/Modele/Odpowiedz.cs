using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Modele
{
    public class Odpowiedz
    {
        public int Id { get; set; }
        public string TrescOdpowiedzi { get; set; }
        public bool CzyPrawidlowa { get; set; }
        public int IdPytania { get; set; }
    }
}
