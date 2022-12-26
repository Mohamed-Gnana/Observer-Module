using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObserver.Observer.Contract
{
    public abstract class Contract : IContract
    {
        public abstract void PrintMessage();
    }
}
