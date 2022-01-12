using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dos
{
    class Program
    {
        static void Main(string[] args)
        {
            byte wiek = 100;
            Osoba o = new Osoba();
            o.imie = "Jan";
            o.nazwisko = "Kowalski";
            o.setWiek(wiek);

            Console.ReadLine();
        }
    }
}
