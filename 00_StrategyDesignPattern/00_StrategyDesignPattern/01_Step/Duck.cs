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
        {
            Console.WriteLine("Can Fly");
        }
      
    }
}