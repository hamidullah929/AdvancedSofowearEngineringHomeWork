using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._02_Step
{
    class MallerDuck  :Iquackbale,IFlyable
    {
        public void Disply()
        {
            Console.WriteLine("Look Like Mallerr Duck");
        }

        public void fly()
        {
            Console.WriteLine("can fly");
        }

        public void quack()
        {
            Console.WriteLine("Can quack");
        }
    }
}
