using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);
            int y = x;

            int a = 2, b;
            b = a + x++;

            Console.WriteLine(b);
            Console.WriteLine($"valor de x = {x}");

            int c = 3, d;
            d = c + --y;

            Console.WriteLine(d);
            Console.WriteLine($"valor de x = {y}");



        }
    }
}
