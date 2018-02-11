using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var isTrue = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int p = i+1; p < arr.Length; p++)
                {
                    
                    var sum = arr[i] + arr[p];

                     if (arr.Contains(sum))
                        {
                            Console.WriteLine($"{arr[i]} + {arr[p]} == {sum}");
                            isTrue = true;
                        }
                    
                }
               
            }
            if (isTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
