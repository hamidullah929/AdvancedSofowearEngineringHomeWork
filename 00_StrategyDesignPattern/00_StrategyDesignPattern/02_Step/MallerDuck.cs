using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._02_Step
{
    class MallerDuck  :Duck, Iquackbale
    {
        public void Disply()
        {
            Console.WriteLine("Look Like Mallerr Duck");
        }
        public void quack()
        {
            Console.WriteLine("Can quack");
        }
    }
}
