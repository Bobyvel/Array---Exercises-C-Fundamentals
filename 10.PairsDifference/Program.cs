using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.PairsDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var num = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == num)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
