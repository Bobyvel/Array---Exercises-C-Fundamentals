using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.MultiplyArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var multuplayer = double.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multuplayer;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
