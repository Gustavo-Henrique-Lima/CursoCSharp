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
            float n6=4.5f;
            double n7=4.5;
            bool completo=true;
            char genero='M';
            string nome="Gustavo";//Não é considerado primitivo em C#
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(nome);
            int n8=int.MinValue;
            long n9=long.MinValue;
            decimal n10=decimal.MaxValue;
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
        }
    }
}