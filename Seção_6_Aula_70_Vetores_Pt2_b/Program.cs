using System;

namespace Seção_6_Aula_70_Vetores_Pt2_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de produtos: ");
            int prdQty = int.Parse(Console.ReadLine());

            ClassVetores[] prdVect = new ClassVetores[prdQty];

            for(int i = 0; i < prdQty; i++)
            {
                Console.Write("Nome do produto: ");
                string prdName = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double prdPrice = double.Parse(Console.ReadLine());
                prdVect[i] = new ClassVetores { Name = prdName, Price = prdPrice };
            }

            double prdSum = 0.0;
            for(int i = 0; i < prdQty; i++)
            {
                prdSum += prdVect[i].Price;
            }

            double prdAVG = prdSum / prdQty;

            Console.WriteLine("Preço médio: {0:F2}", prdAVG);
        }
    }
}
