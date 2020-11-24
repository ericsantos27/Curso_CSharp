using System;

namespace Seção_3_Aula_21_Conversão_Implicita_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implícita //

            float x = 4.5f;
            double y = x;
            global::System.Console.WriteLine(y);

            // Conversão explícita (casting) //

            double z;
            float w;

            z = 6.1;
            w = (float)z;
            Console.WriteLine(w);

            double c;
            int d;

            c = 5.2;
            d = (int)c;
            Console.WriteLine(d);

            int e = 5;
            int f = 2;
            double r = e / f;
            Console.WriteLine(r);

            int g = 5;
            int h = 2;
            double r2 = (double)g / h;
            Console.WriteLine(r2);

        }
    }
}
