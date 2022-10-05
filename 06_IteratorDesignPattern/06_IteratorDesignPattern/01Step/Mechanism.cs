using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IteratorDesignPattern._01Step
{
    class Mechanism
    {
        public void CheckList()
        {
            var peson = new List<string>() { "khan", "jan", "bacha" };

            var list = peson.GetEnumerator();


            while (list.MoveNext())
            {
                Console.WriteLine(list.Current);
            }
            //Console.WriteLine(list.Current);
            //Console.WriteLine(list.MoveNext());
            //Console.WriteLine(list.Current);
            //Console.WriteLine(list.MoveNext());
            //Console.WriteLine(list.Current);
            //Console.WriteLine(list.MoveNext());
            //Console.WriteLine(list.Current);
            //Console.WriteLine(list.MoveNext());
            //Console.WriteLine(list.Current);
        }

    }
}
