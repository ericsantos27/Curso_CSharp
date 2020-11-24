using System;

namespace Seção_6_Aula_80_Exercício_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de posições da matriz: ");
            int nMat = int.Parse(Console.ReadLine());

            int[,] matrix = new int[nMat, nMat];

            /* Atribuir valores às posições da matriz */
            /* Primeiro 'for' para as linhas. O segundo 'for', dentro do primeiro é para as colunas */
            for(int i = 0; i < nMat; i++)
            {
                /* Criar um 'split' como um vetor para atribuir as posições às linhas */
                Console.Write("Valores da linha {0}: ", i + 1);
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < nMat; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for(int i = 0; i < nMat; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < nMat; i++)
            {
                for(int j = 0; j < nMat; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        count++;
                    } 
                }
            }
            Console.WriteLine("Números negativos na matriz: {0}", count);
        }
    }
}
