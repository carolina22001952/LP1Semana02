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

            volume = (float)Math.PI * (float)Math.Pow(radius, 2) * height;
            sArea = (2 * (float)Math.PI) * radius * (radius + height);

            Console.WriteLine($"Volume = {volume:f3}\nSurface Area = {sArea:f3}");
        }
    }
}
