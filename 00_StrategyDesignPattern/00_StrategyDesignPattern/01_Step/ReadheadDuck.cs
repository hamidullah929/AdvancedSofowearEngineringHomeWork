using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern
{
    class ReadheadDuck: Duck
    {
        public void Display()
        {
            Console.WriteLine("Look like ReadHeadDuck");
        }

        override
        public void quack()
        {

        }
    }
}
