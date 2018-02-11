using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] word = Console.ReadLine().ToLower().ToCharArray();


            var alpabet = new char[26];
            var position = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {

                alpabet[position] = i;
                position++;

            }

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alpabet.Length; j++)
                {
                    if (word[i] == alpabet[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }


            }

            //for (int i = 0; i < word.Length; i++)//print ASCII
            //{
            //    for (int k = 'a'; k <= 'z'; k++)
            //    {
            //        if (word[i] == k)
            //        {
            //            Console.WriteLine($"{word[i]} -> {k}");
            //        }
            //    }
            //}

        }
    }
}
