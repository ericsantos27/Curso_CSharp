using System;

namespace Seção_6_Aula_75_Sintaxe_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sintaxe opcional para o 'for' - Leitura: "Para cada objeto x contido no vetor faça: " */

            /* Sintaxe 'for' */
            string[] vect = new string[] { "Matheus", "Maria", "João" };
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("____________________________________________________________");

            /* Sintaxe Foreach */

            foreach(string element in vect)
            {
                Console.WriteLine(element);
            }
        }
    }
}
