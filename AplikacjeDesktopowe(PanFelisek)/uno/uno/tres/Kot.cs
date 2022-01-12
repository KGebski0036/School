using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    class Kot : Zwierze
    {
       
        public override void DajGlos()
        {
            Console.WriteLine($"{imie}: mow mow");
        }

        public void WejdzNaDrzewo()
        {
            Console.WriteLine($"{imie}: Nie będziesz mi mówił jak mam żyć");
        }
    }
}
