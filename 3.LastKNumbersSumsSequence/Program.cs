using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var arr = new long[n]; //ще станат големи
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int p = i-k; p < i; p++)
                {
                    if (p >= 0)
                    {
                        arr[i] += arr[p];
                    }
                   
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
