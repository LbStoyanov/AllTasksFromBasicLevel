using System;

namespace _07.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal farenheit = 32.0m;
            var degrees = decimal.Parse(Console.ReadLine());
            var result = (degrees * 1.80m) + farenheit;
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
