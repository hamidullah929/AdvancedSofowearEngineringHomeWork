using System;

namespace _05_FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch = new Chesses();
            var anar = new AnarPizza();
            var obj = new OrderPizza();
            obj.OrderMyPizza(anar);
            obj.OrderMyPizza(ch);
         
            Console.WriteLine("Hello World!");
        }
    }
}
