using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.ClassWork
{
    internal class Employee
    {
        int _Age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName=> $"{FirstName}{LastName}";

        public int Age
        {
            get => _Age;
            set => _Age = value;
        }
           
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName="Iqubal", LastName="Zafar"};
            Console.WriteLine(employee.FullName);
            employee.Age = 20;
            Console.WriteLine(employee.Age);

        }
        

    }
}
