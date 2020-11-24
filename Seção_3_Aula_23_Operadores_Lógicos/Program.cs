using System;

namespace Seção_3_Aula_23_Operadores_Lógicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // condição 'E' representada pelo símbolo " && "//

            bool c1 = 4 != 5;
            bool c2 = 2 > 5 && 4 != 6;

            // condição 'OU' representada pelo símbolo " || " //

            bool c3 = 3 != 4;
            bool c4 = 3 > 6 || 3 != 5;

            // condição 'NÃO' representada pelo símbolo '!' //

            bool c5 = !(3 > 6) && 3 != 5;
            bool c6 = c1 || c5 && c3;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6);

        }
        
    }
}
