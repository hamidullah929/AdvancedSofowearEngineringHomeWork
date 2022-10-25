using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FactoryDesignPattern._02_Step
{
  public abstract  class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("It is prepared");
        }

        public abstract void Bake();
        public void Cut()
        {
            Console.WriteLine("cutting pizza");
        }
        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}