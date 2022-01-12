using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    class Delegaty
    {
        static public int Operuj(int x, int y, Func<int,int,int> operacja)
        {
            return operacja(x, y);
        }
        static public void TestDelegaty()
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj operacje: ");
            char operacja = Console.ReadLine()[0];
            int wynik;

            switch (operacja)
            {
                case '+':
                    wynik = Operuj(x, y, (a, b)  => a + b);
                    Console.WriteLine(wynik);
                    break;
                case '-':
                    wynik = Operuj(x, y, (a, b) => a - b);
                    Console.WriteLine(wynik);
                    break;
                case '*':
                    wynik = Operuj(x, y, (a, b) => a * b);
                    Console.WriteLine(wynik);
                    break;

            }
           
        }
        static public void GrupoweWywolanie()
        {
            Action delegataAkcji;

            delegataAkcji = Metoda1;
            delegataAkcji();

            delegataAkcji += Metoda2;
            delegataAkcji();
        }
        static private void Metoda1()
        {
            Console.WriteLine("AAA");
        }
        static private void Metoda2()
        {
            Console.WriteLine("BBB");
        }
    }

}
