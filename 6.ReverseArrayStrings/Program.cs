using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.ReverseArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
