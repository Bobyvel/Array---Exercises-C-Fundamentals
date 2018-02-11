using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.ResizableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int?[4]; //празен масив
            var command = string.Empty; 
            int arrIndex = 0; //начален индекс
            

            while ( (command = Console.ReadLine()) != "end")
            {

                var token = command.Split();
                var number = 0;
               

                if (token[0] == "push")
                {
                   number = int.Parse(token[1]);
                   arr[arrIndex] = number; //настоящ индекс

                   arrIndex++; //следващ индекс
                   
                    if (arrIndex == arr.Length)
                    {
                        var arrTemp = arr;
                        arr = new int?[arr.Length + 4];
                        Array.Copy(arrTemp, arr, arrTemp.Length);
                    }
                }
                else if (token[0] == "pop")
                {
                                      
                    arr[arrIndex-1] = null; //настоящ индекс 
                    arrIndex--; //следващия индекс намалява с една позиция
                }
                else if(token[0] == "removeAt")
                {
                   
                        number = int.Parse(token[1]);
                    
                        for (int i = number; i < arrIndex; i++) //от позицията за махане до следващия празен индекс
                        {

                            arr[i] = arr[i + 1]; //сменя им местата
                                               
                        }
                       
                        arrIndex--; //следващия индекс намалява с една позиция
                    
                }
                else if (token[0] == "clear")
                {
                   Array.Clear(arr, 0, arr.Length);
                   arrIndex = 0;
                }
            }

            if (arr.Max() > 0)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                Console.WriteLine("empty array");
            }
            
        }
    }
}
