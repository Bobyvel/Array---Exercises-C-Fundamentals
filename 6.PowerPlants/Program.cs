using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var day = 0;
            var season = 0;
           
            while (arr.Sum() != 0)
            {

                for (int days = 0; days < arr.Length; days++) // days in season
                {
                    for (int flower = 0; flower < arr.Length; flower++) //flowers by days
                    {
                        if (days != flower && arr[flower] > 0) //тук!!!
                        {
                            arr[flower] --;
                            
                        }

                    }

                    day++;
                    if (arr.Sum() == 0)
                    {
                        break;
                    }
                }

                if (arr.Sum() == 0)
                {
                    break;
                }

                for (int i = 0; i < arr.Length; i++) //new season
                    {
                        if (arr[i] > 0)
                        {
                            arr[i] ++;
                        }
                    }
                    season++;
                
               
            }
            if (season == 1)
            {
                Console.WriteLine($"survived {day} days ({season} season)");

            }
            else
            {
                Console.WriteLine($"survived {day} days ({season} seasons)");

            }

        }
    }
}
