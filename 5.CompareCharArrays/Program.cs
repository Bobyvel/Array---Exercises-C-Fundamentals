using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var shortArr = Math.Min(arr.Length, arr1.Length);

            for (int i = 0; i < shortArr; i++)
            {
                if (arr[i] != arr1[i])
                {
                    if (arr[i] < arr1[i] )
                    {
                        Console.WriteLine(string.Join("", arr));
                        Console.WriteLine(string.Join("", arr1));
                    }
                    else 
                    {
                        Console.WriteLine(string.Join("", arr1));
                        Console.WriteLine(string.Join("", arr));
                    }
                   return;
                }
            }
            if (arr.Length < arr1.Length)
            {
                Console.WriteLine(string.Join("", arr));
                Console.WriteLine(string.Join("", arr1));
            }
            else
            {
                Console.WriteLine(string.Join("", arr1));
                Console.WriteLine(string.Join("", arr));
                
            }

        }
    }
}
