using System;

namespace _32.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearCondition = Console.ReadLine().ToLower();
            double p = int.Parse(Console.ReadLine());
            double h = int.Parse(Console.ReadLine());

            double allWeekends = 48;
            double weekendsInSofia = (allWeekends - h) * 3 / 4;

            double homeTownPlays = h;
            double playsInSofia = p * 2 / 3;

            double totalPlays = weekendsInSofia + homeTownPlays + playsInSofia;
            double ifYear = 0;

            if (yearCondition == "leap")
            {
                ifYear = (15 * totalPlays) / 100;
            }
            double final = Math.Truncate(ifYear + totalPlays);
            Console.WriteLine(final);

        }
    }
}
