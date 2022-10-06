using _06_IteratorDesignPattern._02_Step;
using System;
using System.Collections.Generic;

namespace _06_IteratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesList emp = new(3);

            emp.AddEmployee("khan", "jan","070");
            emp.AddEmployee("khan", "jan", "070");
            emp.AddEmployee("karim", "bacha", "070");


            foreach (var item in emp)   
            {
                Console.WriteLine(item);
            }
        }
    }
}
