using System;

namespace _08.Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = 180;
            var radValue = decimal.Parse(Console.ReadLine());
            var result = (rad * radValue) / (decimal)Math.PI;
            Console.WriteLine(Math.Round(result));
        }
    }
}
