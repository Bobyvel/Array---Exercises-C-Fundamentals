using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            var count = 0;
            var maxLenth = 0;
            var startPosition = 0;
            var position = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i+1])
                {
                    count++;
                    if (maxLenth < count)
                    {
                        maxLenth = count;
                        startPosition = position;
                        
                    }
                    

                }
                else
                {
                    position = i+1;
                    count = 0;
                }
            }
            for (int i = startPosition; i <= startPosition + maxLenth; i++) 
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
