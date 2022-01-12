using System;

namespace uno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string imie = "Anon";
            string nazwisko = "Pierwszy";

            Console.WriteLine("Witaj " + imie + " Wielki");
            Console.WriteLine("witaj {1} {0} Wielki", nazwisko, imie);
            Console.WriteLine($"witaj {imie} Wielki");

            Console.WriteLine("Prędkość w km\\h");
            Console.WriteLine(@"Prędkość w km\h");

            int liczba = 5;

            int[] tablica = new int[5];
            int rozmiar = tablica.Length;
            tablica[1] = 6;

            int a;
            a = 5;
            int b = a;
            b = 6;
            
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Osoba OsobaPierwsza = new Osoba();
            OsobaPierwsza.imie = "Anon";
            OsobaPierwsza.nazwisko = "Gigantyczny";
            OsobaPierwsza.wiek = 18;
            
            Osoba OsobaDruga = new Osoba();
            OsobaDruga.imie = "Anon";
            OsobaDruga.nazwisko = "Potężny";
            OsobaDruga.wiek = 21;

            Osoba OsobaTrzecia = OsobaDruga;

            Osoba OsobaCzwarta = OsobaPierwsza;
            OsobaCzwarta.imie = "Anon";
            OsobaCzwarta.nazwisko = "Mocarny";
            OsobaCzwarta.wiek = 37;

            Console.WriteLine($"Osoba 1: {OsobaPierwsza.imie} {OsobaPierwsza.nazwisko} Level: {OsobaPierwsza.wiek}");
            Console.WriteLine($"Osoba 2: {OsobaDruga.imie} {OsobaDruga.nazwisko} Level: {OsobaDruga.wiek}");
            Console.WriteLine($"Osoba 3: {OsobaTrzecia.imie} {OsobaTrzecia.nazwisko} Level: {OsobaTrzecia.wiek}");
            Console.WriteLine($"Osoba 4: {OsobaCzwarta.imie} {OsobaCzwarta.nazwisko} Level: {OsobaCzwarta.wiek}");

            Console.WriteLine("-------------------------");

            int x;
            x = 5;
            Console.WriteLine("X = " + x);
            Metoda1(x);
            Console.WriteLine("X = " + x);
            x = Metoda1_1(x);
            Console.WriteLine("X = " + x);
            Metoda1_2(ref x);
            Console.WriteLine("X = " + x);

            int y;
            Metoda1_3(out y);

            Osoba o = new Osoba();
            o.imie = "Jan";
            Console.WriteLine("o.imie = " + o.imie);
            Metoda2(o);
            Console.WriteLine("o.imie = " + o.imie);
        }

        static void Metoda1 (int a)
        {
            Console.WriteLine("Metoda1 a = " + a);
            a++;
            Console.WriteLine("Metoda1 a = " + a);
        } 
        
        static void Metoda1_2 (ref int a)
        {
            Console.WriteLine("Metoda1_2 a = " + a);
            a++;
            Console.WriteLine("Metoda1_2 a = " + a);
        }
        static void Metoda1_3(out int a)
        {
            a = 99;
            Console.WriteLine("Metoda1_3 a = " + a);
        }

        static int Metoda1_1(int a)
        {
            Console.WriteLine("Metoda1_1 a = " + a);
            a++;
            Console.WriteLine("Metoda1_1 a = " + a);
            return a;
        }

        static void Metoda2(Osoba a)
        {
            Console.WriteLine("Metoda2 a.imie = " + a.imie);
            a.imie = "Adam";
            Console.WriteLine("Metoda2 a.imie = " + a.imie);
        }
    }
}
