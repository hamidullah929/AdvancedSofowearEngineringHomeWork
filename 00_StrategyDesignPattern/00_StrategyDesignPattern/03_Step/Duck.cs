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
    class Duck
    {

        IFlyBhavior flyBhavior;
        Iquackbale quackbale;
        public Duck()
        {
           
        }

        public void setFlyBehavior(IFlyBhavior f)
        {
            flyBhavior = f;

        }

        public void setQuackBehavior(Iquackbale q)
        {
            quackbale = q;
        }
     
        public void performQuack()
        {
            quackbale.quack();
        }

        public void performFly()
        {
            flyBhavior.Fly();
        }
    }
}
