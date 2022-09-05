using _00_StrategyDesignPattern._03_Step.FlyingDuck;
using _00_StrategyDesignPattern._03_Step.QuackingDuck;
using System;

namespace _00_StrategyDesignPattern._03_Step
{
    class Program
    {
        static void Main(string[] args)
        {

            Duck malled = new MallerDuck();
            malled.setQuackBehavior(new Quack());
            malled.setFlyBehavior(new FlynoWay());
            malled.performQuack();
            malled.performFly();
           
            Console.WriteLine("Hello World!");
        }
    }
}
