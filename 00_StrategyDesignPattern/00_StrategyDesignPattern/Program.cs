using _00_StrategyDesignPattern._03_Step.FlyingDuck;
using _00_StrategyDesignPattern._03_Step.QuackingDuck;
using System;

namespace _00_StrategyDesignPattern._03_Step
{
    class Program
    {
        static void Main(string[] args)
        {

            MallerDuck malled = new MallerDuck();
            malled.Display();
            malled.setQuackBehavior(new Quack());
            malled.setFlyBehavior(new FlynoWay());
            malled.performQuack();
            malled.performFly();

            ReadHeadDuck redheadDuck = new ReadHeadDuck();
            redheadDuck.Display();
            redheadDuck.setQuackBehavior(new Squeak());
           
            Console.WriteLine("Hello World!");
        }
    }
}
