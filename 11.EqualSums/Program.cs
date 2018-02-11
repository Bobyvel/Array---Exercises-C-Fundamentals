using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool hasSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                var leftPart = arr.Take(i).ToArray();
                var rigthPart = arr.Skip(i+1).ToArray();

                if (leftPart.Sum() == rigthPart.Sum())
                {
                    Console.WriteLine(i);
                    hasSum = true;
                }
            }

            if (!hasSum)
            {
                Console.WriteLine("no");
            }

            //second way
            var sumLeft = 0;
            var sumRight = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //left
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr[j];
                }
                //right
                for (int k = i+1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    return;
                }

                sumLeft = 0;
                sumRight = 0;

                
            }
            Console.WriteLine("no");
        }
    }
}
