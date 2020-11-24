using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar //

            int _num = int.Parse(Console.ReadLine());

            if (_num % 2 == 0)
            {
                Console.WriteLine("Número par");
            }

            else Console.WriteLine("Número ímpar");
        }
    }
}
