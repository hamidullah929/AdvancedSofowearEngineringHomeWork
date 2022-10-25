using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FactoryDesignPattern._02_Step
{
    class Factory
    {
        public Pizza CreatePizza(Pizza _pizza)
        {
            if (_pizza is Chesses)
            {
                _pizza = new GreekPizza();
            }
            if (_pizza is AnarPizza)
            {
                _pizza = new AnarPizza();
            }

            return _pizza;
        }
    }
}
