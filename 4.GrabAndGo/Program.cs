using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            var lastIndex = -1;
            long sum = 0;
            
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (n == arr[i])
                {
                    lastIndex = i;
                    break;
                }
            }
            for (int i = 0; i < lastIndex; i++)
            {
                sum += arr[i];

            }
            if (lastIndex > -1)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }

           
        }
    }
}
