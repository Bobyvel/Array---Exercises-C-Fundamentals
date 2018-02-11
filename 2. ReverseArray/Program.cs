using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var arr = new int [n];

            for (int i = n-1; i >= 0; i--)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
