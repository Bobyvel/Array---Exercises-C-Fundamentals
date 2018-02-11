using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.OddNumbersOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] % 2) == 1 && i % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {arr[i]}");
                }
            }
        }
    }
}
