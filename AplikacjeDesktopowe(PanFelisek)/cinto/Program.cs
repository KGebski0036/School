using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Portów:");
            IOPort klawiatura = new Usb("klawiatura");
            klawiatura.PostData(klawiatura.GetData());

            IOPort myszka = new Usb("myszka");
            myszka.PostData(myszka.GetData());

            IOPort rzutnik = new Hdmi("rzutnik");
            rzutnik.PostData(rzutnik.GetData());

            IOPort ekran = new Hdmi("ekran");
            ekran.PostData(ekran.GetData());

            MotherBoard motherBoard = new MotherBoard();

            Console.WriteLine("\nGetInfoPorts bez portów:");
            motherBoard.GetInfoPorts(); //error

            Console.WriteLine("\nDodanie portów:");
            motherBoard.AddPort(klawiatura);
            motherBoard.AddPort(myszka);
            motherBoard.AddPort(ekran);
            motherBoard.AddPort(rzutnik);

            Console.WriteLine("\nInformacje o portach:");
            motherBoard.GetInfoPorts();

            Console.WriteLine("\nZczytanie danych z portów:");
            for(int i = 0; i < 5; i++)
            {
                motherBoard.GetDataFromPorts();
            }

            Console.WriteLine("\nZczytanie danych z pamięci:");
            motherBoard.ReadDataFromMemory();

            Console.WriteLine("\nTest wysłania danej 9 do kolejno 0, 1, 2 i nie istniejącego 9:");
            motherBoard.PostDataToPort(9, 0);
            motherBoard.PostDataToPort(9, 1);
            motherBoard.PostDataToPort(9, 2); 
            motherBoard.PostDataToPort(9, 9); //error

            Console.WriteLine("\nTest wysłania danej 999 do wszystkich portów:");
            motherBoard.PostDataToAllPorts(999);


            Console.ReadLine();

        }
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
}

