using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecortingObjectsDesignPattern._01_Step.Flavors
{
    class Mocha:Coffee
    {
        Coffee coffee;
        public Mocha(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public override double Cost()
        {
            return coffee.Cost() + 2;
        }

        public override void Description()
        {
            throw new NotImplementedException();
        }
    }
}
