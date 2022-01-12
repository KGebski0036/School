using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cinto
{
    class MotherBoard
    {
        private List<IOPort> availablePorts_ = new List<IOPort>();
        private Stack<int> memory_ = new Stack<int>();
        public void AddPort(IOPort port)
        {
            Console.WriteLine($"Dodałem port: {port.Info()}");
            availablePorts_.Add(port);
        }
        public void GetDataFromPorts()
        {
            foreach(IOPort port in availablePorts_)
            {
                memory_.Push(port.GetData());
            }
        }

        public void ReadDataFromMemory()
        {
            foreach (int data in memory_)
            {
                Console.Write($"{data} ");
            }
            Console.WriteLine();
        }
        public void PostDataToPort(int data, uint portIndex)
        {
            if (availablePorts_.Count > portIndex)
            {
                availablePorts_[(int)portIndex].PostData(data);
            }
            else
            {
                Console.WriteLine("No available Ports");
            }
            
        }
        public void PostDataToAllPorts(int data)
        {
            foreach (IOPort port in availablePorts_)
            {
                port.PostData(data);
            }
        }
        public void GetInfoPorts()
        {
            if(availablePorts_.Count > 0)
            {
                foreach (IOPort port in availablePorts_)
                {
                    Console.WriteLine(port.Info());
                }
            }
            else
            {
                Console.WriteLine("No available Ports");
            }
            
        }

    }
}
