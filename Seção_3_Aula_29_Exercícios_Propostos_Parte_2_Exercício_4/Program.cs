using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas //

            string[] _val = Console.ReadLine().Split(' ');

            int _num1 = int.Parse(_val[0]);
            int _num2 = int.Parse(_val[1]);

            int game_time;

            if (_num1 > _num2)
            {
                game_time = 24 - _num1 + _num2;
                Console.WriteLine("O jogo durou {0} horas(s)", game_time);
            }
            else if (_num1 == _num2)
            {
                game_time = 24;
                Console.WriteLine("O jogo durou {0} horas(s)", game_time);
            }
            else
            {
                game_time = _num2 - _num1;
                Console.WriteLine("O jogo durou {0} hora(s)", game_time);
            }
        }
    }
}
