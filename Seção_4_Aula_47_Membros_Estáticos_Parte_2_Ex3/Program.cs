using System;
using System.Globalization;

namespace Seção_4_Aula_46_Membros_Estáticos_Parte_1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            ClassCalculator.radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double _area = ClassCalculator._Circumference();
            Console.WriteLine("Circunferência = {0}", _area.ToString("F2", CultureInfo.InvariantCulture));

            double _volume = ClassCalculator._Volume();
            Console.WriteLine("Volume = {0}", _volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: {0}", ClassCalculator.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
