using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IteratorDesignPattern._02_Step
{
    class EmployeesList : IEnumerable<Employee>, IEnumerator<Employee>
    {

        int Max = 0;

        int NumberOfItem = 0;

        int position = 0;

        Employee[] employess;

        public EmployeesList(int Max)
        {
            this.Max = Max;

            employess = new Employee[Max];
        }

        public void AddEmployee(string name , string lastname, string phone)
        {
            Employee employee = new();

            employee.setItems(name, lastname, phone);

            if(NumberOfItem >= Max)
            {
                Console.WriteLine("Array is full");
            }
            else
            {
                employess[NumberOfItem] = employee;

                NumberOfItem++;
            }
        }
        public Employee Current => new Employee()
        {
            Name = employess[position].Name,
            LastName = employess[position].LastName,
            Phone = employess[position].Phone
        };

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            
            if(position < employess.Length-1)
            {
                position++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = 0;
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
             return (IEnumerator<Employee>)GetEnumerator();
        }
    }
}
