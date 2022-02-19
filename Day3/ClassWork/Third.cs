using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day3
{
    enum Month
    {
        Jan,Feb,March
    }


    internal class Third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            String str = "";
            ConsoleKeyInfo ck = Console.ReadKey(true);
            
            /*Console.WriteLine("\nPressed key : "+ck.Key);
            if (ConsoleKey.Enter != ck.Key)
                Console.WriteLine("KeyChar:" + ck.KeyChar);*/

            while(ConsoleKey.Enter != ck.Key)
            {
                Console.Write("*");
                str += ck.KeyChar;
                ck = Console.ReadKey(true);
            }
            Console.WriteLine("\nEntered Password : "+str);
        }
    }
}
