using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new List<char>();

            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] % 2 == 0)
                {
                    
                    result.Add((char)(input[i] - arr[i])); //превръща сметката в символ
                }
                else
                {
                    result.Add((char)(arr[i] + input[i]));
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
