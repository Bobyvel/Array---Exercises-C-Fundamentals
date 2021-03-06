﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            var maxLenthArr = Math.Max(arr1.Length, arr2.Length);
            var resultArr = new int[maxLenthArr];

            for (int i = 0; i < maxLenthArr; i++)
            {
                resultArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
