using System;

namespace _21.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 15;
            if (minutes >= 60)
            {
                hour++;
                minutes -= 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");


        }
    }
}
