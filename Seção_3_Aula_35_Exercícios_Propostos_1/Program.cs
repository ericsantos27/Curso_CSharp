using System;

namespace Seção_3_Aula_35_Exercícios_Propostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int _num1 = int.Parse(Console.ReadLine());

            for (int _i = 1; _i <= _num1; _i ++)
            {
                if (_i % 2 != 0)
                {
                    Console.WriteLine(_i);
                }
            }

        }
    }
}
