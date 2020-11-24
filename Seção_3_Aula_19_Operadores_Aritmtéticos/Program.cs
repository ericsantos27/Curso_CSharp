using System;

namespace Seção_3_Aula_19_Operadores_Aritmtéticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N_1 = 3 + 4 * 2;
            Console.WriteLine(N_1);

            int N_2 = (3 + 4) * 2;
            Console.WriteLine(N_2);

            int N_3 = 17 % 3;
            Console.WriteLine(N_3);

            double N_4 = (double)10 / 8;
            Console.WriteLine(N_4);
            // or //
            double N_5 = 10.0 / 8;
            Console.WriteLine(N_5);

            // Fórmula de Bhaskara //

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}
