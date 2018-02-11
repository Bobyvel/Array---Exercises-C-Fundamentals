using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.CountGivenElement
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            //first way
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {

                    count++;
                }
            }
            Console.WriteLine(count);

            //second way
            Console.WriteLine(arr.Count(x => x == n));


        }
    }
}
