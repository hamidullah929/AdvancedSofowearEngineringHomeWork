using System;

namespace _00_StrategyDesignPattern._03_Step
{
    class Program
    {
        static void Main(string[] args)
        {

            MallerDuck malled = new MallerDuck();

            malled.performQuack();
            malled.performFly();
           
            Console.WriteLine("Hello World!");
        }
    }
}
