using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente //

            Console.Write("Digite dois números: ");

            string[] _val = Console.ReadLine().Split(' ');

            int _num1 = int.Parse(_val[0]);
            int _num2 = int.Parse(_val[1]);

            if (_num1 % _num2 == 0 || _num2 % _num1 == 0)
            {
                Console.WriteLine("São Múltiplos");
            }

            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
