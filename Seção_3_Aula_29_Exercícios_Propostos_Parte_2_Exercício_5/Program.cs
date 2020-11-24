using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar //

            /* 
             * 1 Cachorro quente  - 4,00
             * 2 X salada         - 4,50
             * 3 X bacon          - 5,00
             * 4 Torrada simples  - 2,00
             * 5 Refrigerante     - 1,50
             */

            string[] _val = Console.ReadLine().Split(' ');
            double val_1 = int.Parse(_val[0]);
            double val_2 = int.Parse(_val[1]);
            if (val_1 == 1)
            {
                val_1 = 4;
            }
            else if (val_1 == 2)
            {
                val_1 = 4.50;
            }
            else if (val_1 == 3)
            {
                val_1 = 5;
            }
            else if (val_1 == 4)
            {
                val_1 = 2;
            }
            else
            {
                val_1 = 1.5;
            }

            double val_Total = val_1 * val_2;
            Console.WriteLine("Total: R$ {0:F2}", val_Total);
        }
    }
}
