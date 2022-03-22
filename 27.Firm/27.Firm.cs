using System;

namespace _27.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = decimal.Parse(Console.ReadLine());
            var availableDays = decimal.Parse(Console.ReadLine());
            var employeesCount = decimal.Parse(Console.ReadLine());
            var totalDays = availableDays - (availableDays * 0.10m);

            var overtimeHours = (employeesCount * 2) * totalDays;
            
            var availableHoursForFinishingTheProject = (totalDays * 8) * employeesCount + overtimeHours;


            if (hoursNeeded <= availableHoursForFinishingTheProject)
            {
                var difference = availableHoursForFinishingTheProject - hoursNeeded;
                Console.WriteLine($"Yes!{Math.Ceiling(difference)} hours left.");
            }
            else
            {
                var hoursNeededToFinishTheProject = hoursNeeded - availableHoursForFinishingTheProject;
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursNeededToFinishTheProject)} hours needed.");
            }

        }
    }
}
