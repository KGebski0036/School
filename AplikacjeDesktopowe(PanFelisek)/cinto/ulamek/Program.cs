using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulamek
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba1 = 0.3333;
            double liczba2 = 0.75;

            liczba1 = liczba1 * liczba2;

            Console.WriteLine(liczba1);

             //------------------------------------------------------------

            ulamek u1 = new ulamek(1, 3);
            ulamek u2 = new ulamek(3, 4);

            u1.Mnozenie(u2);

            //u1 = u1 * u2; 

            Console.WriteLine(u1);

            Console.ReadLine();
        }
    }
}
