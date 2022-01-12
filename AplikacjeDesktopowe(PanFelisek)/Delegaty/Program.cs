using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegaty.Zdarzenia;
namespace Delegaty
{
    class PorownajOsoby : IComparer<Osoba >
    {
        public int Compare(Osoba x, Osoba y)
        {
            if(x.wiek < y.wiek)
            {
                return -1;
            }
            if (x.wiek > y.wiek)
            {
                return 1;
            }
            return 0;
        }
    }
    class Program
    {
        static int PorownajOsobyFunc(Osoba x, Osoba y)
        {
            return (x.wiek < y.wiek) ? -1 : (x.wiek > y.wiek) ? 1 : 0;
        }

        static void Main(string[] args)
        {
            TestZdarzen test = new TestZdarzen();
            test.TestowanieZdarzen();

            //Delegaty.TestDelegaty();
            //Delegaty.GrupoweWywolanie();
            //List<int> lista_int = new List<int>();

            //lista_int.Add(2);
            //lista_int.Add(1);
            //lista_int.Add(3);
            //lista_int.Add(7);

            //lista_int.Sort();

            //foreach (int it in lista_int)
            //{
            //    Console.WriteLine(it);
            //}


            //List<Osoba> osoby = new List<Osoba>();

            //osoby.Add(new Osoba("Zan", "Rud", 34));
            //osoby.Add(new Osoba("Jan", "Rud", 34));
            //osoby.Add(new Osoba("Pawel", "Jd", 2));
            //osoby.Add(new Osoba("Pat", "Gj", 41));
            //osoby.Add(new Osoba("Mat", "Dj", 99));

            //Console.WriteLine();
            //foreach (Osoba el in osoby)
            //{
            //    Console.WriteLine($"{el.imie} {el.nazwisko} wiek: {el.wiek}");
            //}

            ////osoby.Sort();
            //Console.WriteLine();
            ////osoby.Sort(new PorownajOsoby());
            ////osoby.Sort(PorownajOsobyFunc);
            //osoby.Sort(

            //    (x, y) => (x.wiek < y.wiek) ? -1 : (x.wiek > y.wiek) ? 1 : 0

            //    ); 


            //foreach (Osoba el in osoby)
            //{
            //    Console.WriteLine($"{el.imie} {el.nazwisko} wiek: {el.wiek}");
            //}

            //List<Osoba> osoby_18 = new List<Osoba>();
            //osoby_18 = osoby.Where(x => x.wiek > 18).ToList();

            //Console.WriteLine();
            //Console.WriteLine("Osoby pełnoletnie: ");

            //foreach (Osoba el in osoby_18)
            //{
            //    Console.WriteLine($"{el.imie} {el.nazwisko} wiek: {el.wiek}");
            //}

            Console.ReadKey();
        }
    }
}
