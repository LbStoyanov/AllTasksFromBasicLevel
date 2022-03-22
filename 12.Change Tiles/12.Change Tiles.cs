using System;

namespace _12.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var playgraoundSide = decimal.Parse(Console.ReadLine());
            var playgroundArea = playgraoundSide * playgraoundSide;
            var tileWidth = decimal.Parse(Console.ReadLine());
            var tileLenght = decimal.Parse(Console.ReadLine());
            var tileArea = tileLenght * tileWidth;
            var benchLength = decimal.Parse(Console.ReadLine());
            var benchWidth = decimal.Parse(Console.ReadLine());
            var benchArea = benchLength * benchWidth;
            var totalFreeArea = playgroundArea - benchArea;
            var tilesNeeded = totalFreeArea / tileArea;
            var timeNeeded = tilesNeeded * 0.2m;
            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
