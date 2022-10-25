using _05_FactoryDesignPattern._02_Step;
using System;

namespace _05_FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var gr = new GreekPizza();
            var order = new Order1Pizza();
            order.Order(gr);
         
            Console.WriteLine("Hello World!");
        }

    }
}
