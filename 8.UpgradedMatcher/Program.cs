using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.UpgradedMatcher
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
                var tokens = input.Split();
                var index = Array.IndexOf(product, tokens[0]);

                var presentQuantity = 0L;

                if (index < quantites.Length)
                {
                    presentQuantity = quantites[index];
                }

                var neededQuantity = long.Parse(tokens[1]);

                if (presentQuantity >= neededQuantity)
                {
                    Console.WriteLine("{0} x {1} costs {2:F2}", product[index], neededQuantity, price[index] * neededQuantity);
                    quantites[index] -= neededQuantity;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {product[index]}");
                }
               




                input = Console.ReadLine();
            }
        }
    }
}
