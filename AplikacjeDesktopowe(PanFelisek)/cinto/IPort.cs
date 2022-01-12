using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinto
{
    interface IPort
    {
        void PostData(int data);
        int GetData();
    }
}
