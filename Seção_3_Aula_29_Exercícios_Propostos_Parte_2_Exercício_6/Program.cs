using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo” //

            double _gap = double.Parse(Console.ReadLine());

            if (_gap < 0.0 || _gap > 100.0)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if (_gap <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (_gap <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (_gap <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (_gap <= 100.0)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

        }
    }
}
