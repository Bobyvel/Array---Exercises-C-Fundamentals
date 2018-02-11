using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.DayWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var day = int.Parse(Console.ReadLine());

            if (day > 0 && day <= daysOfWeek.Length)
            {
                Console.WriteLine(daysOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
