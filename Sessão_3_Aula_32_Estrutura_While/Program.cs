using System;
using System.Globalization;

namespace Sessão_3_Aula_32_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double _x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (_x >= 0.0)
            {
                double _root = Math.Sqrt(_x);
                Console.WriteLine(_root.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                _x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");
        }
    }
}
