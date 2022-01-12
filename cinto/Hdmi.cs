using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cinto
{
    class Hdmi : IOPort
    {
        public Hdmi(string name) : base(name)
        {
            portName_ = "HDMI";
        }
        public override int GetData()
        {
            int data = new Random().Next(50, 3000);
            Console.WriteLine($"Pobrano dane {data} z portu {portName_}-{name_}");
            Thread.Sleep(data / 10);
            return data;
        }
        
    }
}
