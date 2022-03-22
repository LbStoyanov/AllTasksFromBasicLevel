using System;

namespace _03._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal b1 = decimal.Parse(Console.ReadLine());
            decimal b2 = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            var result = (b1 + b2) * h / 2;
            Console.WriteLine(result);
        }
    }
}
