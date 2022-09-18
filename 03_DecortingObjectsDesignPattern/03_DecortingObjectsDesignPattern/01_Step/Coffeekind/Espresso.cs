using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecortingObjectsDesignPattern._01_Step.Coffeekind
{
    class Espresso : Coffee
    {
        public override double Cost()
        {
            return 0.1;
        }

        public override void Description()
        {
            throw new NotImplementedException();
        }
    }
}
