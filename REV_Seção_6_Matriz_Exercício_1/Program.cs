using System;

namespace REV_Seção_6_Matriz_Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidades da matriz: ");
            int nMat = int.Parse(Console.ReadLine());
            int[,] matrix = new int[nMat, nMat];
            Console.WriteLine();
            
            for(int i = 0; i < nMat; i++)
            {
                Console.Write("Posições da linha {0}: ", i + 1);
                string[] vect = Console.ReadLine().Split(' ');
                for(int j = 0; j < nMat; j++)
                {
                    matrix[i, j] = int.Parse(vect[j]);
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < nMat; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }

            Console.WriteLine();
            int count = 0;
            for(int i = 0; i < nMat; i++)
            {
                for(int j = 0; j < nMat; j++)
                {
                    if(matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Quantidade de números negativos: {0}", count);
        }
    }
}
