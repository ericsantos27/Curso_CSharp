using System;

namespace Sessão_3_Aula_33_Exercícios_Propostos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
             */

            string[] _cartPoint = Console.ReadLine().Split(' ');
            double _xPoint = double.Parse(_cartPoint[0]);
            double _yPoint = double.Parse(_cartPoint[1]);

            if (_xPoint > 0.0 && _yPoint > 0.0)
            {
                Console.WriteLine("PRIMEIRO");
            }
            else if (_xPoint > 0.0 && _yPoint < 0.0)
            {
                Console.WriteLine("QUARTO");
            }
            else if (_xPoint < 0.0 && _yPoint < 0.0)
            {
                Console.WriteLine("TERCEIRO");
            }
            else if (_xPoint < 0.0 && _yPoint > 0.0) 
            {
                Console.WriteLine("SEGUNDO");
            }

        }
    }
}
