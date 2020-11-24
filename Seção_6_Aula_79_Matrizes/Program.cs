using System;

namespace Seção_6_Aula_79_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Inicialização e instanciação da matriz */
            double[,] matrix = new double[2, 3];

            Console.WriteLine("Quantidade de posições da matriz: {0}", matrix.Length);

            Console.WriteLine("Quantidade de linhas da matriz: {0}", matrix.Rank);

            /* Comando GetLength para saber o tamanho de cada dimensão da matriz */
            Console.WriteLine("Tamanho da primeira dimensão da matriz (linhas): {0}", matrix.GetLength(0));

            Console.WriteLine("Tamanho da segunda dimensão da matriz (colunas): {0}", matrix.GetLength(1));
        }
    }
}
