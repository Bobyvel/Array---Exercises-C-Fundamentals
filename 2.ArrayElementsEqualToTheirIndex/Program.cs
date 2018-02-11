using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var elements = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr[i])
                {
                    elements.Add(arr[i]);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
