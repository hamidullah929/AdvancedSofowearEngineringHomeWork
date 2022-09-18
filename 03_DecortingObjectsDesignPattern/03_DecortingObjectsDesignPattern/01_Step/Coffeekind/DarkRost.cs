using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecortingObjectsDesignPattern._01_Step.Coffeekind
{
    class DarkRost : Coffee
    {
        public override double Cost()
        {
            return 1;
        }

        public override void Description()
        {
            Console.WriteLine("DarkRost Coffe");
        }
    }
}
