using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.Assignment
{
    internal class Count
    {
        public static int[] CountPosSumNeg(params int[] arr)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= 0)
                {
                    count++;
                }else
                {
                    sum += arr[i] ;
                }
            }
            return new int[]{count , sum};
        }

        static void Main(string[] args)
        {
            int[] arr = CountPosSumNeg(1, 2, 3, -10, -5 );
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
