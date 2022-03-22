using System;

namespace _15.Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = decimal.Parse(Console.ReadLine());
            var sourceInput = Console.ReadLine().ToLower();
            var sourceOutput = Console.ReadLine().ToLower();
            if (sourceInput == "mm")
            {
                size = size / 1000.00m;
            }
            else if(sourceInput == "cm")
            {
                size = size / 100;
            }
            else if (sourceInput =="mi")
            {
                size = size / 0.000621371192m;
            }
            else if (sourceInput =="in")
            {
                size = size / 39.3700787m;
            }
            else if (sourceInput == "km")
            {
                size = size / 0.001m;
            }
            else if (sourceInput =="ft")
            {
                size = size / 3.2808399m;
            }
            else if (sourceInput == "yd")
            {
                size = size / 1.0936133m;
            }

            if (sourceOutput == "mm")
            {
                size = size * 1000.00m;
            }
            else if (sourceOutput == "cm")
            {
                size = size * 100;
            }
            else if (sourceOutput == "mi")
            {
                size = size * 0.000621371192m;
            }
            else if (sourceOutput == "in")
            {
                size = size * 39.3700787m;
            }
            else if (sourceOutput == "km")
            {
                size = size * 0.001m;
            }
            else if (sourceOutput == "ft")
            {
                size = size * 3.2808399m;
            }
            else if (sourceOutput == "yd")
            {
                size = size * 1.0936133m;
            }

            Console.WriteLine($"{size} {sourceOutput}");
        }
    }
}
