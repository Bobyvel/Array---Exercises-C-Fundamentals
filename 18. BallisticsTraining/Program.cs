using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18.BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {


            var cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray(); // x, y

            var fireCordinates = Console.ReadLine().Split();

            int x = 0;
            int y = 0;

            for (int i = 0; i < fireCordinates.Length; i += 2) //пропуска числата
            {


                if (fireCordinates[i] == "up")
                {
                    y += int.Parse(fireCordinates[i + 1]);
                }
                else if (fireCordinates[i] == "down")
                {
                    y -= int.Parse(fireCordinates[i + 1]);
                }
                else if (fireCordinates[i] == "left")
                {
                    x -= int.Parse(fireCordinates[i + 1]);
                }
                else if (fireCordinates[i] == "right")
                {
                    x += int.Parse(fireCordinates[i + 1]);
                }


            }

            Console.WriteLine($"firing at [{x}, {y}]");

            if (cordinates[0] == x && cordinates[1] == y)
            {
               
                Console.WriteLine("got \'em!");

            }
            else
            {
               
                Console.WriteLine("better luck next time...");
            }

        }
    }
}

