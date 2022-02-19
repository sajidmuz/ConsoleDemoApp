using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.ClassWork
{
    internal class Employee
    {
        int IdNo;
        string Name;
        static int id;

        public void SetEmoData(int IdNo, string Name)
        {
            this.Name = Name;
            this.IdNo = IdNo;
            id = IdNo+1;
        }

        public void DisplayEmpData()
        {
            Console.WriteLine($"Id:{IdNo}\tName:{Name}");
        }

        public override string ToString()
        {
            return $"Id:{IdNo}\tName:{Name}";
        }

        public Employee()
        {
            this.IdNo = id++;
            this.Name = "admin";
        }

        public Employee(int IdNo)
        {
            this.IdNo=IdNo;
            id = IdNo+1;
        }

        public Employee(string Name)
        { 
            this.Name = Name;
            this.IdNo = id++;
        }

        static Employee()
        {
            id = 100;
        }
        
    }

    class EmployeeMain
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Iqubal");
            emp1.DisplayEmpData();

            Employee emp2 = new Employee("200");
            emp2.SetEmoData(100,"Iqubal");

            Console.WriteLine(emp2);
            Employee emp3 = new Employee();
            
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
        }

    }
}
