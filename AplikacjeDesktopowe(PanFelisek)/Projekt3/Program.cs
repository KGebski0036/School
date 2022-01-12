using System;

namespace Projekt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies = new Pies();
            pies.imie = "Reksio";
            pies.rasa = "Kundel";
            pies.DajGlos();
            pies.Gonlistonosza();
            Kot kot = new Kot();
            kot.imie = "Puszek";
            kot.rasa = "Dachowiec";
            kot.DajGlos();
            kot.WejdzNaDrzewo();


        }

    }
}
