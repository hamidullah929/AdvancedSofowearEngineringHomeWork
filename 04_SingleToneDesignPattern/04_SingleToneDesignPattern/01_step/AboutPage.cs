using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingleToneDesignPattern._01_step
{
    class AboutPage
    {
        public void Aboutmode()
        {
            var seeting = Seetings.createInstance();
            Console.WriteLine(seeting.theme);
        }
    }
}
