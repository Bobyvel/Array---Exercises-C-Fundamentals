using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine().Split();
            var secondArr = Console.ReadLine().Split();
            var countLeft = 0;
            var positionLeft = 0;

            var minLenth = Math.Min(firstArr.Length, secondArr.Length);
            

            for (int i = 0; i < minLenth; i++) //left
            {
                if (firstArr[i] == secondArr[i])
                {
                    countLeft++;
                    if (countLeft == 1)
                    {
                        positionLeft = i;
                    }
                    
                }
            }

            var countRight = 0;
            var positionRight = 0;

            //Array.Reverse(firstArr);
            //Array.Reverse(secondArr);

            //for (int i = 0; i < minLenth; i++) //rigth
            //{
            //    if (firstArr[i] == secondArr[i])
            //    {
            //        countRight++;
            //        if (countLeft == 1)
            //        {
            //            positionRight = i;
            //        }

            //    }
            //}

            //втори вариант

            for (int i = 0; i < minLenth; i++) //rigth
            {
                
                    if (firstArr[firstArr.Length - 1 - i] == secondArr[secondArr.Length - 1 - i])
                   {
                       countRight++;
                      if (countRight == 1)
                       {
                            positionRight = firstArr.Length - 1 - i;
                       }

                    }
            }            

            if (countLeft > countRight)
            {
                Console.WriteLine(countLeft);
                for (int i = positionLeft; i < countLeft; i++)
                {
                    Console.Write("{0} ", firstArr[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(countRight);
                for (int i = countRight+1; i <= positionRight; i++)
                {
                    Console.Write("{0} ", firstArr[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
