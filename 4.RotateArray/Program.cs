using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            var rotatedArr = new string[arr.Length];

            var lastElement = arr[arr.Length-1];
            rotatedArr[0] = lastElement;

            for (int i = 0; i < arr.Length-1; i++)
            {
                rotatedArr[i + 1] = arr[i];
            }

            Console.WriteLine(string.Join(" ", rotatedArr));


            //бавен метод
            var list = Console.ReadLine().Split().ToList();
            var first = list.Last();
            list.Remove(list.Last());
            list.Insert(0, first);

            Console.WriteLine(string.Join(" ", list));

        }
    }
}
