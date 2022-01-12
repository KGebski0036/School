using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace cinto
{
    class Usb : IOPort
    {
       
        public Usb(string name) : base(name)
        {
            portName_ = "USB";
        }
        public override int GetData()
        {
            int data = new Random().Next(50);
            Console.WriteLine($"Pobrano dane {data} z portu {portName_}-{name_}");
            Thread.Sleep(data);
            return data;
        }
       
}
}
