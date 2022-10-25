using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FactoryDesignPattern._02_Step
{
  sealed  class Order1Pizza
    {
       public void Order(Pizza pizza)
        {
            Factory factory = new Factory();

            pizza = factory.CreatePizza(pizza);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
