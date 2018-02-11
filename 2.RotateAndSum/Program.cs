using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            var summed = new int[arr.Length];

            for (int i = 0; i < k; i++)
            {
                var temp = arr[arr.Length - 1];
                for (int m = arr.Length - 1; m > 0; m--)
                {
                    arr[m] = arr[m - 1];
                }

                arr[0] = temp;

                for (int p = 0; p < arr.Length; p++)
                {
                    summed[p] += arr[p];
                }
            }

            Console.WriteLine(string.Join(" ", summed));

        }
    }
}
