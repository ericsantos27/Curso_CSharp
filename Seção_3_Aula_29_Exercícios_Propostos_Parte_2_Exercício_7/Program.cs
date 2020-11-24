
using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos
               ou na origem (x = y = 0). 
               Se o ponto estiver na origem, escreva a mensagem “Origem”. 
               Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

            */

            string[] _val = Console.ReadLine().Split(' ');

            double _x = double.Parse(_val[0]);
            double _y = double.Parse(_val[1]);

            if (_x == 0.0 && _y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (_x == 0.0 && _y != 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (_x != 0.0 && _y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (_x > 0.0 && _y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (_x > 0.0 && _y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (_x < 0.0 && _y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (_x < 0.0 && _y > 0.0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
