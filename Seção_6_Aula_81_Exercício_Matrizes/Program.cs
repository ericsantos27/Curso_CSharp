using System;

namespace Seção_6_Aula_81_Exercício_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de linhas e colunas: ");
            string[] linCol = Console.ReadLine().Split(' ');
            int lines = int.Parse(linCol[0]);
            int colums = int.Parse(linCol[1]);

            int[,] matrix = new int[lines, colums];
            Console.WriteLine();

            for(int i = 0; i < lines; i++)
            {
                Console.Write("Valores da linha {0}: ", i + 1);
                string[] valuesLC = Console.ReadLine().Split(' ');
                for(int l = 0; l < colums; l++)
                {
                    matrix[i, l] = int.Parse(valuesLC[l]);
                }
            }
            Console.WriteLine();

            Console.Write("Digite um número da matriz: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < lines; i++)
            {
                for(int l = 0; l < colums; l++)
                {
                    if(matrix[i, l] == element)
                    {
                        Console.WriteLine("Posição: {0},{1}", i, l);
                        if (l > 0)
                        {
                            Console.WriteLine("Esquerda: {0}", matrix[i, l - 1]);
                        }
                        if (l < colums -1)
                        {
                            Console.WriteLine("Direita: {0}", matrix[i, l + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: {0}", matrix[i - 1, l]);
                        }
                        if (i < lines - 1)
                        {
                            Console.WriteLine("Abaixo: {0}", matrix[i + 1, l]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
