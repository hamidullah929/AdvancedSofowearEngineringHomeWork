﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FactoryDesignPattern._02_Step
{
    class AnarPizza : Pizza

    {
        public override void Bake()
        {
            Console.WriteLine("Baking AnarPizza");
        }
    }
}
