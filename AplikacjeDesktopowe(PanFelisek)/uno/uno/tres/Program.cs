using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Pies pies = new Pies();
            pies.imie = "Pies";
            pies.DajGlos();
            pies.GonListonosza();

            Kot kot = new Kot();
            kot.imie = "Kot";
            kot.DajGlos();
            Console.WriteLine("Wejdz na drzewo");
            kot.WejdzNaDrzewo();

            Console.ReadLine();
        }
    }
}
