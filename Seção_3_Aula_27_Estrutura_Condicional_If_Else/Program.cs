using System;

namespace Seção_3_Aula_27_Estrutura_Condicional_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura condicional ' if ' //
            int x_1 = 10;
            Console.WriteLine("Bom dia!!");
            if (x_1 < 7) {
                Console.WriteLine("Boa tarde !!");
            }
            Console.WriteLine("Boa noite !!!");
            Console.WriteLine("_______________________________________");

            // Estrutura condicional ' if / else ' //
            Console.Write("Digite um número: ");
            int x_2 = int.Parse(Console.ReadLine());
            if (x_2 % 2 == 0) {
                Console.WriteLine("Número par");
                }
            else {
                Console.WriteLine("Número ímpar");
                }
            Console.WriteLine("_______________________________________");

            // Estrutura condicional encadeada //
            Console.Write("What time is it ?: ");
            int t_hour = int.Parse(Console.ReadLine());
            if (t_hour < 12)
            {
                Console.WriteLine("Good morning!!");
            }
            else if (t_hour < 18)
            {
                Console.WriteLine("Good afternoon!!");
            }
            else
            {
                Console.WriteLine("Good evening!!");
            }
            Console.WriteLine("_______________________________________");     
        }
    }
}
