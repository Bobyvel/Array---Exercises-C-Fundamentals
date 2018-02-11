using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.CountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();

            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 1 && char.IsUpper(char.Parse(arr[i])))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //намира всички главни букви и ги печата
            //за по-интересно условие
            var list = new List<char>();
            for (int i = 0; i < arr.Length; i++)
            {
                
                var chars = arr[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if (char.IsUpper(chars[j]))
                    {
                        //може да се добавят в лист
                        Console.WriteLine(chars[j]);
                        list.Add(chars[j]);

                    }
                }
            }
            //тук листа да се печата и броят символите му
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Count());

        }
    }
}
