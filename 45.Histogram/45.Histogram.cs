using System;

namespace _45.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < number; i++)
            {
                var currentNum = double.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    p1++;
                }
                else if (currentNum >= 200 && currentNum <= 399)
                {
                    p2++;
                }
                else if (currentNum > 399 && currentNum <= 599)
                {
                    p3++;
                }
                else if (currentNum > 599 && currentNum <= 799)
                {
                    p4++;
                }
                else if (currentNum > 799)
                {
                    p5++;
                }
            }
            double p1Percentage = (p1 / number) * 100;
            double p2Percentage = (p2 / number) * 100;
            double p3Percentage = (p3 / number) * 100;
            double p4Percentage = (p4 / number) * 100;
            double p5Percentage = (p5 / number) * 100;

            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
            Console.WriteLine($"{p4Percentage:f2}%");
            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}
