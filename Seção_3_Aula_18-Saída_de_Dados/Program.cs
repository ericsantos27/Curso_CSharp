using System;
using System.Globalization;

namespace Seção_3_Aula_18_Saída_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* o comando 'Console.WriteLine dá uma quebra de linha enquanto q o comando Console.Write não quebra a linha */
            Console.Write("Hello World!");
            Console.WriteLine("Hello World, again !!!");
            Console.WriteLine("And again !!");

            /* Imprimindo variáveis */

            char genero = 'F';
            int born_year = 1979;
            double cta_banc = 24892.456834;
            string name = "Eric Santos";
            Console.WriteLine(genero);
            Console.WriteLine(born_year);
            Console.WriteLine(cta_banc);
            Console.WriteLine(name);

            /* Para delimitar o número de casas depois da vírgula */

            Console.WriteLine(cta_banc.ToString("F2"));

            /* Tirando a formatação local e deixando o número com pont em vez de vírgula */

            Console.WriteLine(cta_banc.ToString("F3"));
            Console.WriteLine(cta_banc.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
