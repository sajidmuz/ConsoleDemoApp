using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.ClassWork
{
    internal static class EmployeeExtension
    {
        public static void Display(this Employee employee)
        {
            Console.WriteLine($"{employee.FullName}\t{employee.Age}");
        }
    }

    class ExtensionTest
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Danish";
            employee.LastName = "Jarwar";
            employee.Age = 25;
            employee.Display();
        }
    }
}
