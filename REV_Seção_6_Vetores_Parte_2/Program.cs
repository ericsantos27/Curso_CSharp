using System;

namespace REV_Seção_6_Vetores_Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int numb = int.Parse(Console.ReadLine());

            double[] vector = new double[numb];

            Console.WriteLine("Descrição dos produtos: ");
            for(int i = 0; i < numb; i++)
            {
                Console.Write("Nome: ");
                string prdName = Console.ReadLine();
                Console.Write("Preço: ");
                vector[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            for (int i = 0; i < numb; i++)
            {
                sum += vector[i];
            }
            double avgPrice = sum / numb;

            Console.WriteLine("Preço médio dos produtos: {0:F2}", avgPrice);
        }
    }
}
