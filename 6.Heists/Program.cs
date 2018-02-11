using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input = Console.ReadLine();

            var totalEarnings = 0;
            var totalExpenses = 0;

            while (input != "Jail Time")
            {
                var tokens = input.Split();



                //първи вариант----------------
                var loot = tokens[0];
                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%') //jewels
                    {
                        totalEarnings += prices[0];
                    }
                    else if (loot[i] == '$') //gold
                    {
                        totalEarnings += prices[1];
                    }
                }
                //-------------------------------

                //втори вариант
                var jewels = tokens[0].Where(j => j == '%').Count();
                var gold = tokens[0].Where(j => j == '$').Count();
                totalEarnings += jewels * prices[0] + gold * prices[1];
                //-------------------------------

                totalExpenses += int.Parse(tokens[1]);
                input = Console.ReadLine();
            }

            if (totalEarnings >= totalExpenses)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", totalEarnings-totalExpenses);
            }
            else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", totalExpenses - totalEarnings);
            }
        }
    }
}
