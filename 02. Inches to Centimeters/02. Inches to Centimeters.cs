using System;

namespace _02._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //var centimeters = 2.54m;
            //var input = decimal.Parse(Console.ReadLine());
            //var result = input * centimeters;
            //Console.WriteLine(result);
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}
