using System;

namespace _03._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < numbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber < 400)
                {
                    p2++;
                }
                else if (currentNumber < 600)
                {
                    p3++;
                }
                else if (currentNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double p1Percentage = (p1 / numbers) * 100; 
            double p2Percentage = (p2 / numbers) * 100; 
            double p3Percentage = (p3 / numbers) * 100; 
            double p4Percentage = (p4 / numbers) * 100; 
            double p5Percentage = (p5 / numbers) * 100;
            Console.WriteLine($"{p1Percentage:f2}%");
            Console.WriteLine($"{p2Percentage:f2}%");
            Console.WriteLine($"{p3Percentage:f2}%");
            Console.WriteLine($"{p4Percentage:f2}%");
            Console.WriteLine($"{p5Percentage:f2}%");
        }
    }
}
