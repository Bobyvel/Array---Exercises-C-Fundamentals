using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            bool isSymetric = false;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[arr.Length-1 -i])
                {
                    isSymetric = true;
                }
                else
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            //second way
            var first = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                first[i] = arr[i];
            }

           
            Array.Reverse(arr);

            if (first.SequenceEqual(arr))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
