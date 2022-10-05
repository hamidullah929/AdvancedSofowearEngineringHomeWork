using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_FactoryDesignPattern
{
    public abstract class  Pizza
    {
        public void Prepare(){
          Console.WriteLine("preapre pizza");
        }

        public abstract void  bake();

        public void Cut()
        {
            Console.WriteLine("Cut pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }


    }
}