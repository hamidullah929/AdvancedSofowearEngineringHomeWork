using System;

namespace _00_StrategyDesignPattern
{
    public class Duck
    {
     virtual   public void quack()
        {
            Console.WriteLine("quack");
        }

        public void swim()
        {
            Console.WriteLine("swim");
        }
         
        public void Fly()
        {                   /// add fly to duck classs problem not all duck can fly
            Console.WriteLine("Can Fly");
        }
      
    }
}