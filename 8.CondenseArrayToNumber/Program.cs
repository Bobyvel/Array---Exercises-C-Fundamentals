using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            while (arr.Length > 1)
            {
                var arrCondensed = new int[arr.Length-1]; //прави го с една по-малък всеки път
                for (int i = 0; i < arr.Length - 1; i++) //до едно по-малко, за е в границите на масива
                {
                    arrCondensed[i] = arr[i] + arr[i + 1];
                }

                arr = arrCondensed; //замества единия с другия
            }
            Console.WriteLine(arr[0]);
        }
    }
}
