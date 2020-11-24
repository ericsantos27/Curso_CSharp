using System;
using System.Globalization;

namespace Seção_3_Aula_35_Exercícios_Propostos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de casos: ");
            int _numCases = int.Parse(Console.ReadLine());

            for (int _i = 1; _i <= _numCases; _i++)
            {
                string[] _testValues = Console.ReadLine().Split(' ');
                double _testValue1 = double.Parse(_testValues[0], CultureInfo.InvariantCulture);
                double _testValue2 = double.Parse(_testValues[1], CultureInfo.InvariantCulture);
                double _testValue3 = double.Parse(_testValues[2], CultureInfo.InvariantCulture);

                double _testMP = (_testValue1 * 2.0 + _testValue2 * 3.0 + _testValue3 * 5.0) / 10.0;

                Console.WriteLine(_testMP.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
