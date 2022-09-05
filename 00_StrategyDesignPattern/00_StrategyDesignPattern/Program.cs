using System;

namespace _00_StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var MDuck = new MallerDuck();
            MDuck.Display();
            var readHead = new ReadheadDuck();
            readHead.quack();
            Console.WriteLine("Hello World!");
        }
    }
}
