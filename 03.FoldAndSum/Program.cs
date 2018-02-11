using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // the cool way
            var arr = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            var left = arr.Take(arr.Count / 4).Reverse().ToArray(); //left part
            
            var center = arr.Skip(arr.Count / 4).Take(arr.Count / 2).ToArray(); //center part

            var right = arr.Reverse<int>().Take(arr.Count / 4).ToArray(); //right part
                        
            var folded = left.Concat(right).ToArray(); //folded part

            var summed = folded.Zip(center, (a, b) => (a + b)).ToArray();

            Console.WriteLine(string.Join(" ", summed));

            //stantart

            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numsFirst = new int[arr1.Length / 2];
            var numsSecond = new int[arr1.Length / 2];

            // left part
            int n = (arr1.Length - 1) / 4; //count indexes
            for (int j = 0; j < arr1.Length / 4; j++)
            {
                numsFirst[n] = arr1[j];
                n--;
            }
            // right part
            n = (numsFirst.Length) / 2;
            for (int i = arr1.Length - 1; i >= arr1.Length - arr1.Length / 4; i--)
            {
                numsFirst[n] = arr1[i];
                n++;
            }
            // center part

            n = 0;
            for (int i = numsSecond.Length / 2; i < arr1.Length - numsSecond.Length / 2; i++)
            {
                numsSecond[n] = arr1[i];
                n++;
            }
            //summed

            for (int i = 0; i < numsSecond.Length; i++)
            {
                numsFirst[i] += numsSecond[i];
            }

            Console.WriteLine(string.Join(" ", numsFirst));

        }
        
    }
}
