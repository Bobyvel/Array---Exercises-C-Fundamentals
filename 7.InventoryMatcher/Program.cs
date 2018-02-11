using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().Split();
            var quantites = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "done")
            {
               var index =  Array.IndexOf(product, input);

                Console.WriteLine($"{product[index]} costs: {price[index]}; Available quantity: {quantites[index]}");

                input = Console.ReadLine();
            }
        }
    }
}
