using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split();

                if (tokens[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (tokens[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (tokens[0] == "Replace")
                {
                    arr = Replace(tokens, arr);

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", arr));
        }

        private static string[] Replace(string[] tokens, string[] arr)
        {

            var index = int.Parse(tokens[1]);
            var text = tokens[2];

            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                arr[index] = text;
                
            }
            return arr;
        }
    }
}
