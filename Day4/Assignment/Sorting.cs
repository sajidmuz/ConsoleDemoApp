using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.Assignment
{
    internal class Sorting
    {
        public static int SortDescending(int num)
        {
            //Convert int to int array
            int[] arr = new int[num.ToString().Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = num%10;
                num /= 10;
            }
            
            return ArrayToNum(SortNum(arr));
        }

        //Take input as integer array and return array in descending order 
        public static int[] SortNum(int[] arr)
        {   int temp;
            for(int i = 0; i < arr.Length - 1;i++)
            {
                for(int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] < arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }

        //Take input as integer array and convert to int and return;
        public static int ArrayToNum(int[] arr)
        {
            int num = 0;
            int x = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                num += (int)(arr[i] * Math.Pow(10, x++));
            }
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positie Number : ");
            int num = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine(SortDescending(num));
            
        }

    }
}
