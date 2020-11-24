using System;

namespace REV_Seção_6_Matriz_Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite as quantidades da matriz: ");
            string[] qty = Console.ReadLine().Split(' ');
            int vect1 = int.Parse(qty[0]);
            int vect2 = int.Parse(qty[1]);
            Console.WriteLine();

            int[,] matrix = new int[vect1,vect2];

            for(int i = 0; i < vect1; i++)
            {
                Console.Write("Linha {0}: ", i + 1);
                string[] vectLin = Console.ReadLine().Split(' ');
                for(int j = 0; j < vect2; j++)
                {
                    matrix[i, j] = int.Parse(vectLin[j]);
                }
            }
            Console.WriteLine();
            Console.Write("Digite o valor: ");
            int matPos = int.Parse(Console.ReadLine());
            for (int i = 0; i < vect1; i++)
            {
                for(int j = 0; j < vect2; j++)
                {
                    if(matrix[i,j] == matPos)
                    {
                        Console.WriteLine("Position {0},{1}:", i, j);
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: {0}", matrix[i, j - 1]);
                        }
                        if(j < vect2 - 1)
                        {
                            Console.WriteLine("Direita: {0}", matrix[i, j + 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Acima: {0}", matrix[i - 1, j]);
                        }
                        if(i < vect1 - 1)
                        {
                            Console.WriteLine("Abaixo: {0}", matrix[i + 1, j]);
                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
