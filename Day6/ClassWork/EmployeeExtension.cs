using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.ClassWork
{
    internal static class EmployeeExtension
    {
        static void Display(this Employee employee)
        {
            Console.WriteLine($"{employee.FullName}\t{employee.Age}");
        }
    }

    class ExtensionTest
    {

    }
}
