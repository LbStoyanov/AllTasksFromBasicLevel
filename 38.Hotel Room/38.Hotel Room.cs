using System;

namespace _38.Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            
            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.00;
                apartmentPrice = 65.00;
                if (nightsCount > 7 && nightsCount <= 14)
                {
                    studioPrice -= (studioPrice * 0.05);
                }
                else if (nightsCount > 14)
                {
                    studioPrice -= (studioPrice * 0.30);
                    apartmentPrice -= (apartmentPrice * 0.10);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nightsCount > 14)
                {
                    studioPrice -= (studioPrice * 0.20) ;
                    apartmentPrice -= (apartmentPrice * 0.10);
                    
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76.00;
                apartmentPrice = 77.00;
                if (nightsCount > 14)
                {
                    apartmentPrice -= (apartmentPrice * 0.10);
                }
            }

            var totalStudioPrice = studioPrice * nightsCount;
            var totalApartmentPrice = apartmentPrice * nightsCount;

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
