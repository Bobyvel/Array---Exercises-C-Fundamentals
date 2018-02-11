using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var minNum = arr.Min();
            var maxNum = arr.Max();
            var sumNum = arr.Sum();
            var averageNum = arr.Average();

            Console.WriteLine("Min = {0}", minNum);
            Console.WriteLine("Max = {0}", maxNum);
            Console.WriteLine("Sum = {0}", sumNum);
            Console.WriteLine("Average = {0}", averageNum);

        }
    }
}
