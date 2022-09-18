using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SingleToneDesignPattern._01_step
{
   public  class Seetings
    {
      private static  Seetings seetings = null;
        public string theme { get; set; } = "Light";
        public string font { get; set; }
        private Seetings()
        {

        }

        public static Seetings createInstance()
        {
            if(seetings == null)
            {
                return new Seetings();
            }

            return seetings;
        }
    }
}
