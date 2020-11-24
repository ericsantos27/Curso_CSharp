using System;
using System.Globalization;

namespace Seção_4_Aula_46_Membros_Estáticos_Parte_1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCalculator _sphere = new ClassCalculator();

            Console.Write("Digite o valor do raio: ");
            _sphere.radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double _area = _sphere._Circumference();
            Console.WriteLine("Circunferência = {0}", _area.ToString("F2", CultureInfo.InvariantCulture));

            double _volume = _sphere._Volume();
            Console.WriteLine("Volume = {0}", _volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: {0}", _sphere.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
