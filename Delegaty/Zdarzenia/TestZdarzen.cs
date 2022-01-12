using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty.Zdarzenia
{
    class TestZdarzen
    {
        public void TestowanieZdarzen()
        {
            int liczbaUrzytkownika;
            Ibserwator obserwator = new Ibserwator();

            while (!int.TryParse(Console.ReadLine(), out liczbaUrzytkownika)) { Console.WriteLine("Nieprawidłowa liczba"); }

            Liczba l = new Liczba();
            l.delegataZmianaNr = obserwator.Wyswietl;

            l.Numer = liczbaUrzytkownika;

           


        }
    }
}
