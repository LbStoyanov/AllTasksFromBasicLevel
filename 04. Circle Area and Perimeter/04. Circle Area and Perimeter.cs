using System;

namespace _04._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = decimal.Parse(Console.ReadLine());
            var circleArea = (decimal)Math.PI * r * r;
            var circlePerimeter = 2 * (decimal)Math.PI * r;
            Console.WriteLine($"Area={circleArea}");
            Console.WriteLine($"Perimeter={circlePerimeter}");
        }
    }
}
