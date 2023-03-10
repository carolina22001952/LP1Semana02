using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            string heightStr, radiusStr;
            float height, radius, volume, sArea;

            Console.WriteLine("Altura:");
            heightStr = Console.ReadLine();
            Console.WriteLine("Raio:");
            radiusStr = Console.ReadLine();

            height = float.Parse(heightStr);
            radius = float.Parse(radiusStr);

            volume = (float)3.1415926 * (radius * radius) * height;
            sArea = (2 * (float)3.1415926) * radius * (radius + height);

            Console.WriteLine($"Volume = {volume}\nSurface Area = {sArea}");
        }
    }
}
