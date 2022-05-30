using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sum += n;
                if (n > max)
                {
                    max = n;
                }
            }
            int sumWihtoutMaxNumber = sum - max;
            if (max == sumWihtoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int difference = Math.Abs(max - sumWihtoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
