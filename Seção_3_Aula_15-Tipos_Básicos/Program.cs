using System;

namespace Seção_3_Aula_15_Tipos_Básicos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tipo 'sbyte' */
            sbyte SB = 100;
            Console.WriteLine(SB);

            /* Tipo 'byte' */
            byte BY = 125;
            Console.WriteLine(BY);

            /* Tipo 'int' */
            int IT = 2147483647;
            Console.WriteLine(IT);

            /* Tipo 'long' */
            long LG = 2147483648L;
            Console.WriteLine(LG);

            /* Tipo 'bool */
            bool is_comp = false;
            Console.WriteLine(is_comp);

            /* Tipo 'char' */
            char gen = 'F';
            Console.WriteLine(gen);

            /* Tipo 'char' com caractere delta da tabela unicode */
            char delta = '\u03A8';
            Console.WriteLine(delta);

            /* Tipo 'float' */
            float FL = 4.5f;
            Console.WriteLine(FL);

            /* Tipo 'double' */
            double DB = 4.5;
            Console.WriteLine(DB);

            /* Tipo 'string' */
            String STR = "Eric Santos";
            Console.WriteLine(STR);

            /* Tipo 'object' Tipo genérico universal que aceita valores de qualquer tipo */
            object Nome = "Maria do Carmo";
            object Num = 41.5f;
            Console.WriteLine(Nome);
            Console.WriteLine(Num);

            /* Comando para saber o valor mínimo de um tipo */
            int n1 = int.MinValue;
            long n2 = long.MinValue;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            int n3 = int.MaxValue;
            long n4 = long.MaxValue;
            Console.WriteLine(n3);
            Console.WriteLine(n4);
                      
        }
    }
}
