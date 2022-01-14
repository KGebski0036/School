using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulamek
{
    class ulamek
    {
        private int licznik;
        private int mianownik;

        public ulamek(int l,int m)
        {
            licznik = l;
            mianownik = m;
        }
        #region Operacje arytmetyczne 

        public void Mnozenie(ulamek u)
        {
            licznik = licznik * u.licznik;
            mianownik = mianownik * u.mianownik;
        }
        #endregion

        public override string ToString()
        {
            return licznik + "/" + mianownik;
        }

    }

}
