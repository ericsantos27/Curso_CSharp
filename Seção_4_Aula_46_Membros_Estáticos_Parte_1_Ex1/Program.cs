using System;
using System.Globalization;

namespace Seção_4_Aula_46_Membros_Estáticos_Parte_1_Ex1
{
    class Program
    {
        static double _Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double _area = _Circumference(radius);
            Console.WriteLine("Circunferência = {0}", _area.ToString("F2", CultureInfo.InvariantCulture));

            double _volume = _Volume(radius);
            Console.WriteLine("Volume = {0}", _volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: {0}", _Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double _Circumference(double rad)
        {
            return (2.0 * _Pi) * rad;
        }

        static double _Volume(double rad)
        {
            return (4.0 * _Pi * (Math.Pow(rad, 3))) / 3;
        }
    }
}
