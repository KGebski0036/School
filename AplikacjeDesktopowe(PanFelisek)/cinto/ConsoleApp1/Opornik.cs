using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opornik
{
    class Opornik
    {
        protected double rezystancja;

        public double Rezystancja
        {
            get { return rezystancja; }
            set
            {
                if (value > 0)
                {
                    rezystancja = value;
                }
                else
                {
                    throw new Exception("rezystancja nie może być mniejsza lub równa 0");
                }
            }
        }

        public Opornik(double rezystancja)
        {
            Rezystancja = rezystancja;
        }
        public Opornik()
        {
            this.rezystancja = 1;
        }

        #region override
        public override string ToString()
        {
            return rezystancja.ToString() + '\n';
        }
        #endregion

        #region operatory
   
        public static Opornik operator +(Opornik first, Opornik second)
        {
            return new Opornik(first.rezystancja + second.rezystancja);
        }

        public static Opornik operator &(Opornik first, Opornik second)
        {
            if (first.rezystancja != 0 && second.rezystancja != 0)
            {
                return new Opornik(1 / first.rezystancja + 1 / second.rezystancja);
            }
            else
            {
                return new Opornik();
            }
        }

        
        #endregion

        #region konwersje
        public static implicit operator Opornik(double val)
        {
            return new Opornik(val);
        }
        #endregion
    }
}
