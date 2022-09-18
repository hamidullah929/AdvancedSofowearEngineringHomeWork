using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingleToneDesignPattern._01_step
{
    class HomePage
    {
        public void Hoo()
        {
            var seeting = Seetings.createInstance();
            seeting.theme = "HomepageLight";
            Console.WriteLine(seeting.theme);
        }
    }
}
