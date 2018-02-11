using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.CountOfNegativeElements
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
            Console.WriteLine(arr.Count(x=> x < 0));

            //second way
            var negativeCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {

                    negativeCount++;
                }
            }

            Console.WriteLine(negativeCount);
        }
    
    }
}
