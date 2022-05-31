using System;

namespace _03._Santas_Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            const double RoomForOnePersonPrice = 18.00;
            const double ApartmentPrice = 25.00;
            const double PresidentApartmentPrice = 35.00;

            double numberOfDaysToStay = double.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string raiting = Console.ReadLine();            
            var totalPriceForRoomForOnePerson = RoomForOnePersonPrice * (numberOfDaysToStay - 1);
            var totalPriceForApartment = ApartmentPrice * (numberOfDaysToStay - 1);
            var totalPriceforPresidentApartment = PresidentApartmentPrice * (numberOfDaysToStay - 1);
            if (numberOfDaysToStay <= 0)
            {
                Console.WriteLine("0.00");
                return;
            }
            if (typeOfRoom == "apartment")
            {
                
                if (numberOfDaysToStay < 10)
                {
                      totalPriceForApartment -= totalPriceForApartment * 0.30;
                }
                else if (numberOfDaysToStay <= 15)
                {
                     totalPriceForApartment -= totalPriceForApartment * 0.35;
                }
                else if (numberOfDaysToStay > 15)
                {
                    totalPriceForApartment -= totalPriceForApartment * 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {

                if (numberOfDaysToStay < 10)
                {
                   totalPriceforPresidentApartment -= totalPriceforPresidentApartment * 0.10;
                }
                else if (numberOfDaysToStay <= 15)
                {
                    totalPriceforPresidentApartment -= totalPriceforPresidentApartment * 0.15;
                }
                else if (numberOfDaysToStay > 15)
                {
                    totalPriceforPresidentApartment -= totalPriceforPresidentApartment * 0.20;
                }
            }
            
            
            if (raiting == "positive")
            {
                if (typeOfRoom == "apartment")
                {
                    totalPriceForApartment += totalPriceForApartment * 0.25;
                    Console.WriteLine($"{totalPriceForApartment:f2}");
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPriceforPresidentApartment += totalPriceforPresidentApartment * 0.25;
                    Console.WriteLine($"{totalPriceForApartment:f2}");
                }
                else if (typeOfRoom == "room for one person")
                {
                    totalPriceForRoomForOnePerson += totalPriceForRoomForOnePerson * 0.25;
                    Console.WriteLine($"{totalPriceForRoomForOnePerson:f2}");
                }                                
            }
            else if (raiting == "negative")
            {
                if (typeOfRoom == "apartment")
                {
                    totalPriceForApartment -= totalPriceForApartment * 0.10;
                    Console.WriteLine($"{totalPriceForApartment:f2}");
                }
                else if (typeOfRoom == "president apartment")
                {
                    totalPriceforPresidentApartment -= totalPriceforPresidentApartment * 0.10;
                    Console.WriteLine($"{totalPriceforPresidentApartment:f2}");
                }
                else if (typeOfRoom == "room for one person")
                {
                    totalPriceForRoomForOnePerson -= totalPriceForRoomForOnePerson * 0.10;
                    Console.WriteLine($"{totalPriceForRoomForOnePerson:f2}");
                }
                

            } 

            
            
        }
    }
}
