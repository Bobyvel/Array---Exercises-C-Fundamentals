using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.CountOccurrencesLargerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());
            //first way
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > p)
                {

                    count++;
                }
            }
            Console.WriteLine(count);

            //second way
            Console.WriteLine(arr.Count(x => x > p));

        }
    }
}
