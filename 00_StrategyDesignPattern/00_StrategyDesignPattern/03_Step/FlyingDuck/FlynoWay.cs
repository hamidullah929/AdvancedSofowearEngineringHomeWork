using _00_StrategyDesignPattern._03_Step.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._03_Step.FlyingDuck
{
    class FlynoWay : IFlyBhavior
    {
        public void Fly()
        {
            Console.WriteLine("The Duck is not flying");
        }
    }
}
