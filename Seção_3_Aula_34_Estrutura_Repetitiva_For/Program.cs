using System;

namespace Seção_3_Aula_34_Estrutura_Repetitiva_For
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Estrutura de repetição "for"
             * 
             * for ( início ; condição ; incremento ) 
             * {
             *      Comando 1
             *      Comando 2
             * }
             * 
             * onde:
             * Elemento "início" = executado pelo programa somente na primeira vez
             * Elemento "condição" = semelhante a estrutura "while". Se verdadeiro, executa o código e volta. Se falso, pula fora
             *Elemento "incremento" = é executado toda vez q o programa volta ao início
             * 
            */

            Console.Write("Quantos números serão digitados?: ");
            int _n = int.Parse(Console.ReadLine());
            int _sum = 0;

            for (int _i = 1; _i <= _n; _i ++)
            {
                Console.Write("Valor n.{0}: ", _i);
                int _value = int.Parse(Console.ReadLine());
                _sum += _value;
            }
            Console.WriteLine("Soma: {0}", _sum);
        }
    }
}
