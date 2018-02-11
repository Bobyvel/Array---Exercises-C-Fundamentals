using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.SmallestElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // var smalestNum = int.MaxValue;


            //for (int i = 0; i < arr.Length-; i++)
            //{
            //    if (arr[i] < smalestNum)
            //    {
            //        smalestNum = arr[i];
            //    }
            //}

            var smalestNum = arr.Min();


            Console.WriteLine(smalestNum);
        }
    }
}
