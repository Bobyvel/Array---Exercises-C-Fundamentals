using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if(command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                    
                }
                else if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    var text = command[2];

                    arr[index] = text;
                }
               
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
