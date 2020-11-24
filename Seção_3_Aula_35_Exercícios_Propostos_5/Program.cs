using System;

namespace Seção_3_Aula_35_Exercícios_Propostos_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número para fatorar: ");
            int _numFat = int.Parse(Console.ReadLine());
            int _fat = 1;

            for (int _i = 1; _i <= _numFat; _i++)
            {
                _fat = _fat * _i;
            }
            Console.WriteLine(_fat);
        }
    }
}
