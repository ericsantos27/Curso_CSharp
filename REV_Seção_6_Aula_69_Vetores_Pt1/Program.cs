using System;

namespace REV_Seção_6_Aula_69_Vetores_Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de entradas: ");
            int numb = int.Parse(Console.ReadLine());
            
            double[] vector = new double[numb];

            for (int i = 0; i < numb; i++)
            {
                Console.Write("Altura {0}: ", i + 1);
                vector[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            double sum = 0.0;
            for (int i = 0; i < numb; i++)
            {
                sum += vector[i];
            }
            double avg = sum / numb;
            Console.WriteLine("Altura média: {0:F2}", avg);
        }
    }
}
