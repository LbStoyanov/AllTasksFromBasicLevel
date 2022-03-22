using System;

namespace _63.Number_in_Range__1_100_
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"The number is: {num}");
        }
    }
}
