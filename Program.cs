using System;

namespace CursoC
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n1=127;//Min -128
            short n2=32767;//Min -32768
            int n3=2147483647;//Min -2147483648
            long n4=9223372036854775806L;//Min -9223372036854775808
            byte n5=255;//Min 0
            bool completo=true;
            char genero='M';
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
        }
    }
}