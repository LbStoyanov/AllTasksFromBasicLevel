using System;
using System.Collections.Generic;

namespace _42.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var maxNum = double.MinValue;

            for (int i = 0; i < num; i++)
            {
                var currentNum = double.Parse(Console.ReadLine());
                
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                sum += currentNum;
                
            }

            var sumMinusMaxNum = sum - maxNum;
            if (sumMinusMaxNum == maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                if (maxNum > sumMinusMaxNum)
                {
                    var difference = maxNum - sumMinusMaxNum;
                    Console.WriteLine($"No");
                    Console.WriteLine($"Diff = {difference}");
                }
                else
                {
                    var difference = sumMinusMaxNum - maxNum;
                    Console.WriteLine($"No");
                    Console.WriteLine($"Diff = {difference}");
                }
            }
        }
    }
}
