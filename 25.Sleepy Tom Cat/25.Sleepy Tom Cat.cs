using System;

namespace _25.Sleepy_Tom_Cat
{
    class Program
    {
        static void Main()
        {
            var daysOff = int.Parse(Console.ReadLine());
            var hoursNeededForSleep = 30000m;
            var workingDays = 365 - daysOff;
            var totalHoursOfworkingDayPlay = workingDays * 63;
            var totaHoursOfHolidaysPlay = daysOff * 127;
            var totalHoursOfPLay = totaHoursOfHolidaysPlay + totalHoursOfworkingDayPlay;
            //ar difference = 0.0m;
            if (hoursNeededForSleep < totalHoursOfPLay)
            {
                var hours = (totalHoursOfPLay - hoursNeededForSleep) / 60;
                var minutes = (totalHoursOfPLay - hoursNeededForSleep) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes:f0} minutes more for play");
            }
            else
            {
                var hours = (hoursNeededForSleep - totalHoursOfPLay) / 60;
                var minutes = (hoursNeededForSleep - totalHoursOfPLay) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes:f0} minutes less for play");
            }
        }
    }
}
