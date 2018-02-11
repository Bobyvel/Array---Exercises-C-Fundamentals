using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            var receipe = new List<string>();

            var count = 0;

            
                foreach (var ingrediant in arr)
                {
                    if (ingrediant.Length == n)
                    {
                        Console.WriteLine("Adding {0}.", ingrediant);
                        receipe.Add(ingrediant);
                        count++;

                        if (count == 10)
                        {
                            break;
                        }
                    }
                }

            Console.WriteLine("Made pizza with total of {0} ingredients.", count);
            Console.WriteLine("The ingredients are: " + string.Join(", ", receipe) + ".");
            
        }
    }
}
