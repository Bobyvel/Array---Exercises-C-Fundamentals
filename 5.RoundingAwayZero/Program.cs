using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.RoundingAwayZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();


            foreach (var num in arr)
            {
                var roundedNum = Math.Round(num, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{num} => {roundedNum}");
            }
        }
    }
}
