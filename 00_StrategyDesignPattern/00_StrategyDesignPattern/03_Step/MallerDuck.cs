using _00_StrategyDesignPattern._03_Step.contract;
using _00_StrategyDesignPattern._03_Step.FlyingDuck;
using _00_StrategyDesignPattern._03_Step.QuackingDuck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_StrategyDesignPattern._03_Step
{
    class MallerDuck : Duck
    {
        IFlyBhavior flyBhavior;
        Iquackbale quackbale;
        public MallerDuck()
        {
            quackbale = new Quack();
            flyBhavior = new FlyWithWings();
        }


        public void performQuack()
        {
            quackbale.quack();
        }

        public void performFly()
        {
            flyBhavior.Fly();
        }
        public void Display()
        {
            Console.WriteLine("MallerDuck is showing");
        }
    }
}
