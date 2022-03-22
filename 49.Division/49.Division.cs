using System;

namespace _49.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < numbers; i++)
            {
                var currentNum = double.Parse(Console.ReadLine());
                if (currentNum % 2 == 0)
                {
                    p1++;
                }
                if (currentNum % 3 == 0)
                {
                    p2++;
                }
                if (currentNum % 4 == 0)
                {
                    p3++;
                }
            }

            var p1InPercentage = (p1 / numbers) * 100;
            var p2InPercentage = (p2 / numbers) * 100;
            var p3InPercentage = (p3 / numbers) * 100;

            Console.WriteLine($"{p1InPercentage:f2}%");
            Console.WriteLine($"{p2InPercentage:f2}%");
            Console.WriteLine($"{p3InPercentage:f2}%");
        }
    }
}
