using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);

            int a = 2, b;
            b = a + x++;

            Console.WriteLine(b);
            Console.WriteLine(x);
            
        }
    }
}
