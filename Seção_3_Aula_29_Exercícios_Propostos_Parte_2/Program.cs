using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não //

            int _num = int.Parse(Console.ReadLine());

            if (_num < 0) {
                Console.WriteLine("Número negativo");
            }

            else Console.WriteLine("Número positivo");

        }
    }
}
