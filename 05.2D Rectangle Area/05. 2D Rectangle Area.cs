using System;

namespace _05._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            
        }
    }
}
