using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day4.Assignment
{
    internal class ArrayOfArrays
    {
        public static int[] NewArray(int[,] arr)
        {
            int max = 0;
            int[] newArr = new int[arr.GetLength(0)];
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    if(arr[i,j] > max)
                    {
                        //Console.WriteLine(arr[i,j]);
                        max = arr[i,j];
                    }
                   
                }
                newArr[i] = max;
                max = 0;
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[,] { { 1, 20, 3,10 }, { 4, 5, 6,11 }, { 7,8,9,12} };

            int[] arr1 = NewArray(arr);
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(arr1[0]);
        }
    }
}
