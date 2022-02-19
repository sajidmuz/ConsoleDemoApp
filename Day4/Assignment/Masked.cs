using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.Assignment
{
    internal class Masked
    {
        public static string Maskify(string str)
        {
            if(str.Length >= 4)
            {
                return str.Substring(str.Length - 4).PadLeft(str.Length,'#');
            }
            else
            {
                return str;
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to maskyfi : ");
            string str = Console.ReadLine();
            Console.WriteLine(Maskify(str));
        }
    }
}
