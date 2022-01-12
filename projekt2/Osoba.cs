using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    class Osoba
    {
       
        public string Imie
        {
            get;
            set;
        }
        private string nazwisko;
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                nazwisko = value;
            }
        }
        private byte wiek;
        public byte Wiek
        {
            get
            {
                return wiek;
            }
            set
            {
            if (value < 150)
                this.wiek  = value;
            else
                throw new Exception("za duza wartosc pola wiek");
            }
        }
        /*public void SetWiek(byte wiek)
        {

        }*/
        public byte GetWiek()
        {
            return wiek;
        }

    }
}
    