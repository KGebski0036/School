using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dos
{
    class Osoba
    {
        
        public string imie;
        
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
                    wiek = value;
                else
                    throw new Exception("Za duża wartość pola wiek");
            }
        
        }
        
        public void setWiek(byte value)
        {
            if (value < 150)
                wiek = value;
            else
                throw new Exception("Za duża wartość pola wiek");

        }

        public byte GetWiek()
        {
            return wiek;
        }

        

    }
}
