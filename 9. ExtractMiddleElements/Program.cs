using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            if (arr.Length == 1)
            {
                Console.WriteLine("{" +  arr[0] + "}");
            }
            else if (arr.Length % 2 == 1) //odd
            {
                Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}, {arr[arr.Length / 2 + 1]}");
            }
            else if (arr.Length % 2 == 0) //even
            {
                Console.WriteLine($"{arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]}");
            }
        }
    }
}
