using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cinto
{
    abstract class IOPort : IPort
    {
        protected string name_;  
        protected string portName_;
        public IOPort(string name)
        {
            name_ = name;
        }
        public void PostData(int data)
        {
            Console.WriteLine($"Wysłono dane {data} z portu {portName_}-{name_}");
        }
        public abstract int GetData();
        public string Info()
        {
            return ($"{portName_}-{name_}");
        }
        
        
    }
}
