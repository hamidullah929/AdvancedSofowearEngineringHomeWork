using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._02_Step
{
    // here the problem is when you change the interface you should change all the class again that is code
    // and code is doblicated again in every class
    class Duck
    {
        public void swim()
        {
            Console.WriteLine("Can sswim");
        }
        public void Display()
        {
            Console.WriteLine("I have display");
        }
       
    }
}
