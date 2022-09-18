using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._02_Step
{
    class ReadhatDuck : Duck, IFlyable
    {
        public void fly()
        {
            Console.WriteLine("I am readhead duck and i can fly");
        }
    }
}
