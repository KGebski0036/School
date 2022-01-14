using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty.Zdarzenia
{
    class Liczba
    {
        private int numer;
        public Action<int> delegataZmianaNr;
        public int Numer{
            get
            {
                return numer;
            }
            set
            {
                numer = value;
                if (delegataZmianaNr != null)
                {
                    delegataZmianaNr(value);
                }
            }
        }


    }
}
