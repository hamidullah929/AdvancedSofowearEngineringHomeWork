using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._03_Step.QuackingDuck
{
    class Squeak : Iquackbale
    {
        public void quack()
        {
            Console.WriteLine("The duck is Squeaking");
        }
    }
}
