using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();

            long initialAltitude = int.Parse(arr[0]); //има смятане, може да превърти

            for (int i = 1; i < arr.Length; i+= 2) //пропуска числата
            {
                if (arr[i] == "up")
                {
                    initialAltitude += int.Parse(arr[i+1]);
                }
                else if (arr[i] == "down")
                {
                    initialAltitude -= int.Parse(arr[i + 1]);
                }

                if (initialAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {initialAltitude}m");
        }
    }
}
