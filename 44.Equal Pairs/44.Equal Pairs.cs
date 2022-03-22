using System;
using System.Collections.Generic;

namespace _44.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var pareOfNumber = int.Parse(Console.ReadLine());
            var previousSum = 0;
            var difference = 0;
            for (int i = 0; i < pareOfNumber; i++)
            {
                
                if (i == 0)
                {
                    var firstNum = int.Parse(Console.ReadLine());
                    var secondNum = int.Parse(Console.ReadLine());
                    previousSum = firstNum + secondNum;
                    
                    
                }
                else
                {
                    var currentNum1 = int.Parse(Console.ReadLine());
                    var currentNum2 = int.Parse(Console.ReadLine());
                    var currentSum = currentNum1 + currentNum2;
                    if ((Math.Abs(currentSum - previousSum)) > difference)
                    {
                        difference = Math.Abs(currentSum - previousSum);

                    }
                    previousSum = currentSum;
                }
            }

            if (difference > 0)
            {
                Console.WriteLine("No, maxdiff=" + difference);
            }
            else
            {
                Console.WriteLine("Yes, value=" + previousSum);
            }
        }
    }
}
