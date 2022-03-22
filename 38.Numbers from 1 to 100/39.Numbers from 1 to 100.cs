using System;

namespace _38.Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal num = decimal.Parse(Console.ReadLine());
            var leftSum = 0.0m;
            var rightSum = 0.0m;

            for (int i = 0; i < num; i++)
            {
                var currentNum = decimal.Parse(Console.ReadLine());
                leftSum += currentNum;
            }

            for (int i = 0; i < num; i++)
            {
                var currentNum = decimal.Parse(Console.ReadLine());
                rightSum += currentNum;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                var difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
