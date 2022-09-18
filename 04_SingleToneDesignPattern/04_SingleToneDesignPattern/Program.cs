using _04_SingleToneDesignPattern._01_step;
using System;

namespace _04_SingleToneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var loginpage = new LgainPage() ;
            loginpage.Foo();
            var homepage = new HomePage();
            homepage.Hoo();
            var aboutpage = new AboutPage();
            aboutpage.Aboutmode();
            
        }
    }
}
