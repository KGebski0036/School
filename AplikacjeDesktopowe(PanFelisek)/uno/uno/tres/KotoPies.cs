using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tres
{
    class KotoPies : Pies, Kot
    {
        public override void DajGlos()
        {
            Console.WriteLine($"{imie}: wow mow");
        }
    }
}
