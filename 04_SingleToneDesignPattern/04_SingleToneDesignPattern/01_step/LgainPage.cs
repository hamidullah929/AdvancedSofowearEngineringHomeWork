using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingleToneDesignPattern._01_step
{
    class LgainPage
    {
      
        public void Foo()
        {
           var seetings = Seetings.createInstance();
            seetings.theme = "Dark";
            Console.WriteLine(seetings.theme);
           

        }
    }
}
