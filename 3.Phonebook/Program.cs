using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phones = Console.ReadLine().Split();
            var names = Console.ReadLine().Split();

            var input = Console.ReadLine();

            while (input != "done")
            {
               var index = Array.IndexOf(names, input);
                Console.WriteLine($"{names[index]} -> {phones[index]}");
                input = Console.ReadLine();
            }
        }
    }
}
