using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6.ClassWork
{
    internal class Student
    {
        int _RollNo;
        string _Name;
        int _Age;
        string _Course;
        static string _College;

        static Student()
        {
            _College = "Astric";
        }

        //Property for roll no
        public int RollNo
        {
            get { return _RollNo ;}
            set { _RollNo = value ;}
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }

            set 
            {
                if (value > 0)
                    _Age = value;
                else
                    Console.WriteLine("Age must greater than Zero");
            }
        }

        //Write Only Property
        public string Course
        {
            set { _Course = value; }
        }

        //Read Only Property
        public string College
        {
            get { return _College; }
        }

        //AutoImplemented Property without any class data field
        //for such property both get and set accessor are compulsary
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }


        public override string ToString()
        {
            return $"Roll:{_RollNo}\tName:{_Name}\tAge:{_Age}\tCourse:{_Course}\tCollege:{_College}";
        }

        
       
    }

    class StudentMain
    {
        static void Main(string[] args)
        {
            /*Student st = new Student();
            st.RollNo = 1;
            st.Name = "Iqubal";
            st.Age = 23;

            Console.WriteLine(st.ToString());
            Console.WriteLine($"{st.RollNo}\t{st.Name}\t{st.Age}");


            Student st2 = new Student()
            {
                RollNo = 100,
                Name = "Danish",
                Age = 25
            };


            Student st3 = new Student()
            {
                RollNo = 101,
                Name = "Faisal",

            };

            Console.WriteLine(st2);
            Console.WriteLine(st3);

            Student st4 = new Student()
            {
                Course = "PG_DAC"

            };
            Console.WriteLine(st4);

            Student st5 = new Student();
            Console.WriteLine(st5.College);*/

            Student st6 = new Student();
            st6.MyProperty1 = 105;
            st6.MyProperty2 = "Sajid";
            st6.MyProperty3 = 25;

            Console.WriteLine(st6.MyProperty1);
            Console.WriteLine(st6.MyProperty2);
            Console.WriteLine(st6.MyProperty3);

        }

     }
}
