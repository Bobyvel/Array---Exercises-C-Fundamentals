using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.LargestElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
             //first way
            Console.WriteLine(arr.Max());

            //second way
            var maxElement = int.MinValue;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                  
                    maxElement = arr[i];
                }
            }

            Console.WriteLine(maxElement);
        }
    }
}
