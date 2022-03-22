using System;

namespace _34.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double examHour = double.Parse(Console.ReadLine());
            double examMinutes = double.Parse(Console.ReadLine());
            double arrivalHour = double.Parse(Console.ReadLine());
            double arrivalMinutes = double.Parse(Console.ReadLine());
            var totalExamMinutes = (examHour * 60) + examMinutes;
            var totalArriveMinutes = (arrivalHour * 60) + arrivalMinutes;

            if (totalExamMinutes > totalArriveMinutes)
            {
                var difference = totalExamMinutes - totalArriveMinutes;
                int hourDifference = (int)(difference / 60);
                var minutesDifference = difference % 60;
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else if (difference > 30 && difference <= 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else
                {
                    if (minutesDifference < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hourDifference}:0{minutesDifference} hours before the start");
                    }
                    else 
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hourDifference}:{minutesDifference} hours before the start");
                    }
                }
            }
            else if (totalExamMinutes < totalArriveMinutes)
            {
                var difference = totalArriveMinutes - totalExamMinutes;
                int hourDifference = (int)difference / 60;
                var minutesDifference = difference % 60;
                if (difference <= 59)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
                else
                {
                    if (minutesDifference < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hourDifference}:0{minutesDifference} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hourDifference}:{minutesDifference} hours after the start");
                    }
                }
            }
            else if (totalArriveMinutes == totalExamMinutes)
            {
                Console.WriteLine("On time");
            }

        }
    }
}
