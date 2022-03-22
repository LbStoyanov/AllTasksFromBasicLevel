using System;

namespace _09.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = 1.79549m;
            var bgn = decimal.Parse(Console.ReadLine());
            var result = bgn * usd;
            Console.WriteLine($"{result:f2}");
        }
    }
}
