using System;

namespace _06.Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = decimal.Parse(Console.ReadLine());
            var h = decimal.Parse(Console.ReadLine());
            var area = side * h / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
