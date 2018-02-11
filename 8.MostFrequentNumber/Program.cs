using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = 0;
            var maxCount = 0;
            var num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        count++;
                    }
                }
                if (maxCount < count)
                {
                    num = arr[i];
                    maxCount = count;
                }
                count = 0;
            }

            Console.WriteLine(num);
        }
    }
}
