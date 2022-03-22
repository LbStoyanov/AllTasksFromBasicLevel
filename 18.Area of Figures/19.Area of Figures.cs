using System;

namespace _18.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType == "square")
            {
                var side = decimal.Parse(Console.ReadLine());
                var squareArea = side * side;
                Console.WriteLine($"{squareArea}");
            }
            else if (figureType == "rectangle")
            {
                var sideA = decimal.Parse(Console.ReadLine());
                var sideB = decimal.Parse(Console.ReadLine());
                var rectangleArea = sideA * sideB;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (figureType == "circle")
            {
                var r =decimal.Parse(Console.ReadLine());
                var circleArea = (decimal)Math.PI * r *r;
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figureType == "triangle")
            {
                var sideLenght = decimal.Parse(Console.ReadLine());
                var height = decimal.Parse(Console.ReadLine());
                var triangleArea = sideLenght * height / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
        }
    }
}
