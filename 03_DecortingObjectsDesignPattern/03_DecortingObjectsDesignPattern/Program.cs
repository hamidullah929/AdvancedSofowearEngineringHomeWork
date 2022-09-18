using _03_DecortingObjectsDesignPattern._01_Step;
using _03_DecortingObjectsDesignPattern._01_Step.Coffeekind;
using _03_DecortingObjectsDesignPattern._01_Step.Flavors;
using System;

namespace _03_DecortingObjectsDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Coffee coffee1 = new DarkRost();

            coffee1 = new Mocha(coffee1);
            coffee1 = new Whip(coffee1);



            Console.WriteLine(coffee1.Cost());
        }
    }
}
