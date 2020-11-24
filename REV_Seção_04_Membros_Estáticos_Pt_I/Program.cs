using System;

namespace REV_Seção_04_Membros_Estáticos_Pt_I
{
    class Program
    {
        static double pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = circunference(raio);
            double volume = volum(raio);

            Console.WriteLine("Circunferência: {0:F2}", circ);
            Console.WriteLine("Volume: {0:F2}", volume);
            Console.WriteLine("PI: {0:F2}", pi);
        }

        static double circunference (double r)
        {
            return 2.0 * pi * r;
        }
        static double volum (double r)
        {
            return ((4.0 / 3.0) * pi) * Math.Pow(r, 3);
        }
    }
}
