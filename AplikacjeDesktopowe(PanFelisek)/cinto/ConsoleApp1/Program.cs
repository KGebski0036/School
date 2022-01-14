using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opornik
{
    class Program
    {
        static void Main(string[] args)
        {
            Opornik o1 = new Opornik();
            Opornik o2 = new Opornik();

            try
            {
                o1 = new Opornik(5);
                o2 = new Opornik(0);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Opornik1: " + o1 + "Opornik2:" + o2);

            Console.WriteLine("Opornik szeregowy: " + (o1 + o2));
            Console.WriteLine("Opornik szeregowy: " + (o1 & o2));

            Console.ReadLine();
        }
    }
}
