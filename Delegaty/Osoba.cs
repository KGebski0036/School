using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Osoba : IComparable<Osoba>
    {
        public Osoba(string imie_, string nazwisko_, byte wiek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
        }
        public string imie;
        public string nazwisko;
        public byte wiek;

        public const bool plec = true;

        public int CompareTo(Osoba other)
        {
            int i = wiek.CompareTo(other.wiek);
            if(i == 0)
            {
                return imie.CompareTo(other.imie);
            }
            return i;
        }
    }
}
