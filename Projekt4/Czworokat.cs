using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt4
{
    abstract class Czworokat
    {
        protected int bokA, bokB, bokC, bokD;
        protected int pole, obwod;
        protected string nazwa_;
        public Czworokat(int a, int b, int c, int d, string nazwa="")
        {
             nazwa_ = nazwa;
             bokA = a;
             bokB = b;
             bokC = c;
             bokD = d;
        }
        public void ObliczObwod()
        {
            obwod = bokA + bokB + bokC + bokD;
        }
        public abstract void ObliczPole();
        public void WyswietlDane()
        {
            Console.WriteLine();
            Console.WriteLine("Nazwa: " + nazwa_);
            Console.WriteLine("Bok a: " + bokA);
            Console.WriteLine("Bok b: " + bokB);
            Console.WriteLine("Bok c: " + bokC);
            Console.WriteLine("Bok d: " + bokD);
            Console.WriteLine("Pole: " + pole);
            Console.WriteLine("Obwod: " + obwod);
        }
    }
}
