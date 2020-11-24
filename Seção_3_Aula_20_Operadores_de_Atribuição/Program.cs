using System;

namespace Seção_3_Aula_20_Operadores_de_Atribuição
{
    class Program
    {
        static void Main(string[] args)
        {
            // = _ recebe //
            int a = 10;
            Console.WriteLine(a);

            // += _ acrescenta o número a variável //
            a += 2;
            Console.WriteLine(a);

            // *= _ multiplica o valor da variável pelo número após o sinal//
            a *= 3;
            Console.WriteLine(a);

            // usando += para acrescentar valores em string //
            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            // Operadores ++ e -- //
            int a2 = 10;
            a2++;
            Console.WriteLine(a2);

            int a3 = 10;
            a3--;
            Console.WriteLine(a3);
        
        }
    }
}
