using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ObserverDesignpattern.contracts
{
    interface Isubscriber
    {
        public void update(string degree, string pressure);
    }
}
