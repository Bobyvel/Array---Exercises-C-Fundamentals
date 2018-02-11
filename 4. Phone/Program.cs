using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.Phone
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
                var tokens = input.Split();

                if (tokens[0] == "call")
                {
                    var number = String.Empty;
                    if (phones.Contains(tokens[1]))
                    {
                        var index = Array.IndexOf(phones, tokens[1]);
                        Console.WriteLine($"calling {names[index]}...");
                        number = tokens[1];
                    }
                    else
                    {
                        var index = Array.IndexOf(names, tokens[1]);
                        Console.WriteLine($"calling {phones[index]}...");
                        number = phones[index];
                    }


                    int sum = SumDigits(number);

                        if (sum % 2 == 1)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            var minets = sum / 60;
                            var seconds = sum % 60;
                        
                           
                            Console.WriteLine($"call ended. duration: {minets:D2}:{seconds:D2}");
                        }

                }
                else if (tokens[0] == "message")
                {
                    var number = String.Empty;
                    if (phones.Contains(tokens[1]))
                    {
                        var index = Array.IndexOf(phones, tokens[1]);
                        Console.WriteLine($"sending sms to {names[index]}...");
                        number = tokens[1];
                    }
                    else
                    {
                        var index = Array.IndexOf(names, tokens[1]);
                        Console.WriteLine($"sending sms to {phones[index]}...");
                        number = phones[index];
                    }

                    int diference = DiffDigits(number);

                    if (diference % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                       Console.WriteLine("meet me there");
                    }
                }
                




                
                input = Console.ReadLine();
            }
        }

        private static int DiffDigits(string number)
        {
            var diff = 0;
            foreach (var num in number)
            {
                if (char.IsDigit(num))
                {
                    var digit = int.Parse(num.ToString());
                    diff -= digit;
                }

            }

            return Math.Abs(diff);
        }

        private static int SumDigits(string number)
        {
            var sum = 0;
            foreach (var num in number)
            {
                if (char.IsDigit(num))
                {
                    var digit = int.Parse(num.ToString());
                    sum += digit;
                }

            }

            return sum;
        }
    }
}
