using System;

namespace _14.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPerson = int.Parse(Console.ReadLine());
            var secondPerson = int.Parse(Console.ReadLine());
            var thirthPerson = int.Parse(Console.ReadLine());
            var totalSumInSeconds = firstPerson + secondPerson + thirthPerson;
            var minutes = totalSumInSeconds / 60;
            var seconds = totalSumInSeconds % 60; ;
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
           
            

        }
    }
}
