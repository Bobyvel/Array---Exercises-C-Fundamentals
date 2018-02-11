using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var movingIndex = 0;
           
            var sum = 0;
            

            while (movingIndex >= 0 && movingIndex <= arr.Length)
            {
                sum += arr[movingIndex];


                if (movingIndex + arr[movingIndex] < arr.Length)
                {
                    movingIndex += arr[movingIndex];

                }
                else
                {
                    movingIndex -= arr[movingIndex];
                }
            }

                

            
            Console.WriteLine(sum);

        }
    }
}
