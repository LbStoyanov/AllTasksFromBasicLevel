using System;

namespace _66.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
