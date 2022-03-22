using System;

namespace _30.Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = decimal.Parse(Console.ReadLine());
            var y1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            
            var x = decimal.Parse(Console.ReadLine());
            var y = decimal.Parse(Console.ReadLine());

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
