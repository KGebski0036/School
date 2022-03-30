using System;

namespace ProgramPesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesel pesel;
            string peselInput = "";

            Console.WriteLine("podaj swój pesel: ");
            peselInput = Console.ReadLine();

            Console.WriteLine("Wprowadzony pesel: " + peselInput);
            try
            {
                pesel = new Pesel(peselInput);
            }
            catch (PeselError e)
            {
                Console.WriteLine("Jest błędny, bo " + e.Message);
                return;
            }
            Console.WriteLine("Jest Poprawny");

            Console.WriteLine("Rok urodzenia: " + pesel.RokUrodzenia);
            Console.WriteLine("Miesiąc urodzenia: " + pesel.MiesiacUrodzenia);
            Console.WriteLine("Dzień urodzenia: " + pesel.DzienUrodzenia);
            Console.WriteLine("Twoja plec to: " + pesel.Plec);
        }
    }
}
