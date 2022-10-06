using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IteratorDesignPattern._02_Step
{
   public sealed class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public  void setItems(string name, string lastName, string phone)
        {
            Name = name;
            LastName = lastName;
            Phone = phone;
        }

        public string getItem()
        {
            return $"Name : {Name}, Last Name: {LastName}, Phone Number:{Phone} ";
        }

    }
}
