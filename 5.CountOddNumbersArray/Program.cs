using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.CountOddNumbersArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var countOdds = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] % 2) == 1)
                {
                    countOdds++;
                }
            }

            Console.WriteLine(countOdds);
        }
    }
}
