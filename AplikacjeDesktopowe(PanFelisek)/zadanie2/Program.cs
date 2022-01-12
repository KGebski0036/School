using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            namespace to swojego rodzaju katalog pomagajacy nam grupowac w sposob logiczny                                    
            alfanumeryczne, podkreslenia,   musi  byc unikatowa w danej przestrzeni nazw, nie moze zaczynac sie od cyfr.
             
             */
            string nazwisko = "Kowalski";
            string imie = "Jan";
            Console.WriteLine("witaj" + imie + "tutaj");
            Console.WriteLine("witaj{1} {0} tutaj", imie, nazwisko);


            int a;
            a = 5;
            int b = a;
            b = 6;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("Hello worl d  !");          
            int[] tablica = new int[6];
            Console.WriteLine(tablica.Length);
            Osoba osobaPierwsza = new Osoba();
            osobaPierwsza.imie = "Lodzik";
            osobaPierwsza.nazwisko = "Lodzinkski";
            osobaPierwsza.wiek = 21;
            Console.WriteLine(osobaPierwsza.imie);
            Console.WriteLine(osobaPierwsza.nazwisko);
            Console.WriteLine(osobaPierwsza.wiek);

            Osoba osobaDruga = new Osoba();
            osobaDruga.imie = "Jacenty";
            osobaDruga.nazwisko = "Jackowski";
            osobaDruga.wiek = 37;

            Osoba osobaTrzecia = osobaDruga;

            Osoba osobaCzwarta = osobaPierwsza;
            osobaCzwarta.imie = "nieJacenty";
            osobaCzwarta.nazwisko = "nieJackowski";
            osobaCzwarta.wiek = 34;
            Console.WriteLine($"pierwsza {osobaPierwsza.imie} { osobaPierwsza.nazwisko} { osobaPierwsza.wiek}");
            Console.WriteLine($"druga {osobaDruga.imie} { osobaDruga.nazwisko} { osobaDruga.wiek}");
            Console.WriteLine($"trzecia {osobaTrzecia.imie} { osobaTrzecia.nazwisko} { osobaTrzecia.wiek}");
            Console.WriteLine($"czwarta {osobaCzwarta.imie} { osobaCzwarta.nazwisko} { osobaCzwarta.wiek}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"witaj {imie} \\tutaj");


            int x;
            x = 5;
            Console.WriteLine("x: " + x);
            Metoda1(x);
            Console.WriteLine("x: " + x);

            x = Metoda1_1(x);
            Console.WriteLine("x: " + x);
            Metoda1_2(ref x);
            Console.WriteLine("x: " + x);
            int y;
            //Metoda1_2(ref y);
            Metoda1_3(out y);

            Console.WriteLine("---------------------");

            Osoba o = new Osoba();
            o.imie = "jan";
            Console.WriteLine("o imie  " + o.imie);
            Metoda2(o);
            Console.WriteLine("o imie  " + o.imie);
        }
        static void Metoda1(int a)
        {
            Console.WriteLine("Metoda1 a = " + a);
            a++;
            Console.WriteLine("Metoda1 a = " + a);

        }
        static int Metoda1_1(int a)
        {
            Console.WriteLine("Metoda1_1 a = " + a);
            a++;
            Console.WriteLine("Metoda1_1 a = " + a);
            return a;
        }
        static void Metoda1_2(ref int a)
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
        static void Metoda2(Osoba a)
        {

            a.imie = "Adam";

        }
    }
}
