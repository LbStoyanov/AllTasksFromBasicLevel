using System;

namespace _40.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());

            var evenSum = 0.0m;
            var oddSum = 0.0m;

            for (int i = 0; i < numbers; i++)
            {
                var currentNum = decimal.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                var difference = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
