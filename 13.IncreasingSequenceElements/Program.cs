using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.IncreasingSequenceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIncreasing = false;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
               
            }

            if (isIncreasing)
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
