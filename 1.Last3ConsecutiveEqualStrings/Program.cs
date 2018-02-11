using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var sequanse = new List<string>();
            Array.Reverse(arr);

            var count = 1;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                   count ++;
                   sequanse.Add(arr[i]);

                    if (count == 3)
                    {
                        sequanse.Add(arr[i]);
                        Console.WriteLine(string.Join(" ", sequanse));
                        break;
                    }
                }
                   
                else
                {
                    count = 1;
                    sequanse.Clear();
                }
            }


            //втори вариант

            var arr1 = Console.ReadLine().Split();
            var sequanse1 = new List<string>();
            Array.Reverse(arr1);


            for (int i = 0; i < arr1.Length; i++)
            {
                var count1 = 1;
                sequanse1.Clear();

                for (int k = i + 1; k < i + 3; k++)
                {
                    if (k < arr1.Length)
                    {
                        if (arr1[i] == arr1[k])
                        {
                            count1++;
                            sequanse1.Add(arr1[k]);
                        }
                    }
                }
                if (count1 == 3)
                {
                    sequanse1.Add(arr1[i]);
                    Console.WriteLine(string.Join(" ", sequanse1));
                    break;
                }
            }
        }
    }
}
