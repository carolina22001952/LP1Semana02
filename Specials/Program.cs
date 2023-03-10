using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte
            Console.WriteLine
            ($"byte max = {byte.MaxValue}\n byte min = {byte.MinValue}");
            Console.WriteLine
            ($"sbyte max = {sbyte.MaxValue}\n sbyte min = {sbyte.MinValue}");

            //short
            Console.WriteLine
            ($"short max = {short.MaxValue}\n short min = {short.MinValue}");
            Console.WriteLine
            ($"ushort max = {ushort.MaxValue}\n ushort min = {ushort.MinValue}");
            
            //int
            Console.WriteLine
            ($"int max = {int.MaxValue}\n int min = {int.MinValue}");
            Console.WriteLine
            ($"uint max = {uint.MaxValue}\n uint min = {uint.MinValue}");

            //long
            Console.WriteLine
            ($"long max = {long.MaxValue}\n long min = {long.MinValue}");
            Console.WriteLine
            ($"ulong max = {ulong.MaxValue}\n ulong min = {ulong.MinValue}");

            //decimal
            Console.WriteLine
            ($"decimal max = {decimal.MaxValue}\n decimal min = {decimal.MinValue}");

            //float
            Console.WriteLine
            ($"float max = {float.MaxValue}\n float min = {float.MinValue}");

            //double
            Console.WriteLine
            ($"double max = {double.MaxValue}\n double min = {double.MinValue}");

            //infinity and NaN double
            Console.WriteLine
            ($"\n{double.PositiveInfinity} \n{double.NegativeInfinity} \n{double.NaN}");

            //infinity and NaN float
            Console.WriteLine
            ($"\n{float.PositiveInfinity} \n{float.NegativeInfinity} \n{float.NaN}");


            //Overflow integral type
            byte b = byte.MaxValue;
            short s = short.MaxValue;
            int i = int.MaxValue;
            b++;
            s++;
            i++;

            Console.WriteLine($"byte overflow = {b}\nshort overflow = {s}"
            + $"\nint overflow = {i}");

            //Overflow floating point types
            float f = float.MaxValue;
            double d = double.MaxValue;
            f++;
            d++;

            Console.WriteLine($"float overflow = {f}\ndouble overflow = {d}");

        }
    }
}
