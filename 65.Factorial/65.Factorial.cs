using System;

namespace _65.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
