using System;
using System.Globalization;

namespace Add1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var newbirthdate = birthdate.AddDays(1000);
            Console.WriteLine(newbirthdate.ToString("dd-MM-yyyy"));

        }
    }
}