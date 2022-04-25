using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();

            uint client1 = b.AddClient(new Client("Karol", "Gębski",   "209301920939"));
            uint client2 = b.AddClient(new Client("Jacek", "Jaworski", "832989823109"));

            uint konto1 = b.CreateAccount(client1, 1234, "maslo", 11223344);
            uint konto2 = b.CreateAccount(client2, 2137, "root" , 12345678);

            Console.WriteLine("Konta po utwożeniu:");
            b.PokazKlijentow();

   
            b.Wplata(konto1, 2000.0);
            Console.WriteLine("Konta po Wpłacie na 1 konto 2000:");
            b.PokazKlijentow();


            b.Przelew(konto1, konto2, 12.80);
            Console.WriteLine("Konta po przelewie bez zalogowania:");
            b.PokazKlijentow();


            Console.WriteLine("Zalogowanie i przelew:");
            b.Zaloguj(konto2);
            b.Zaloguj(konto1);
            b.Przelew(konto1, konto2, 12.80);
            b.PokazKlijentow();

            Console.ReadKey();
        }
    }
}
