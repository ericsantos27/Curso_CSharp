using System;
using System.Globalization;

namespace Seção_3_Aula_35_Exercícios_Propostos_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de operações: ");
            int _numOp = int.Parse(Console.ReadLine());
            
            for (int _i = 1; _i <= _numOp; _i++)
            {
                string[] _numValues = Console.ReadLine().Split(' ');
                int _val1 = int.Parse(_numValues[0]);
                int _val2 = int.Parse(_numValues[1]);

                if (_val2 == 0)
                {
                    Console.WriteLine("DIVISÃO IMPOSSÍVEL");
                }
                else
                {
                    double _resultValue = (double)_val1 / _val2;
                    Console.WriteLine(_resultValue.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
