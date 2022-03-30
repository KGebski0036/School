using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramPesel
{
    class PeselError : Exception
    {
        public PeselError(string message) : base(message)
        {
        }

    }
    class Pesel
    {
        public int RokUrodzenia { get; set; }
        public int MiesiacUrodzenia { get; set; }
        public int DzienUrodzenia { get; set; }
        public long PeselCyfra { get; set; }
        public string PeselString { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string Plec { get; set; }

        public Pesel(string peselInput)
        {
            if (peselInput.Length != 11)
                throw new PeselError("nie posiada odpowiedniej dłudości");

            PeselString = peselInput;

            SprawdziInput();
            ObliczDateUrodzenia();
            ObliczPlec();
            SprawdzSumeKontrolna();
        }

        private void SprawdziInput()
        {
            foreach(var it in PeselString)
            {
                if (it < '0' || it > '9')
                    throw new PeselError("nie składa się z samych liczb");
            }
        }

        private void SprawdzSumeKontrolna()
        {
            int suma = 0;
            int liczbaKontrolna = Int32.Parse(PeselString.Substring(10, 1));
            List<int> wagiLiczb = new List<int>{ 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            for(int i = 0; i < 10; i++)
            {
                int liczba = Int32.Parse(PeselString.Substring(i, 1));
                suma += (liczba * wagiLiczb[i]) % 10;
            }
            if (liczbaKontrolna != 10 - (suma % 10))
            {
                throw new PeselError("nie posiada prawidłowej liczby kontrolnej");
            }
        }

        private void ObliczPlec()
        {
            int plecNb = Int32.Parse(PeselString.Substring(9, 1));
            if (plecNb % 2 == 0)
            {
                Plec = "Kobieta";
            }
            else
            {
                Plec = "Mężczyzna";
            }
        }

        private void ObliczDateUrodzenia()
        {
            int rok = Int32.Parse(PeselString.Substring(0, 2));
            int miesiac = Int32.Parse(PeselString.Substring(2, 2));
            int dzien = Int32.Parse(PeselString.Substring(4, 2));

            MiesiacUrodzenia = miesiac % 20;

            switch (miesiac - MiesiacUrodzenia)
            {
                case 0:
                    RokUrodzenia = 1900;
                    break;
                case 20:
                    RokUrodzenia = 2000;
                    break;
                case 40:
                    RokUrodzenia = 2100;
                    break;
                case 60:
                    RokUrodzenia = 2200;
                    break;
                case 80:
                    RokUrodzenia = 1800;
                    break;
            }
            RokUrodzenia += rok;

            if (MiesiacUrodzenia > 12 || MiesiacUrodzenia == 0)
            {
                throw new PeselError("nie posiada prawidłowego miesiąca urodzenia");
            }

            DzienUrodzenia = dzien;
            try
            {
                DataUrodzenia = new DateTime(RokUrodzenia, MiesiacUrodzenia, DzienUrodzenia);
            }
            catch (Exception)
            {
                throw new PeselError("nie posiada prawidłowego dnia urodzenia");
            }
        }
    }
}
