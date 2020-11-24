using System;
using System.Globalization;

namespace Seção_6_Aula_70_Vetores_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de produtos: ");
            int prodNum = int.Parse(Console.ReadLine());

            ClassVetores2[] vect2 = new ClassVetores2[prodNum];

            for(int i = 0; i < prodNum; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect2[i] = new ClassVetores2 { ProdName = name, ProdPrice = price };
            }

            double sum = 0.0;

            for(int i = 0; i < prodNum; i++)
            {
                sum += vect2[i].ProdPrice;
            }

            double avg = sum / prodNum;

            Console.WriteLine("AVERAGE PRICE = {0:F2}", avg);
        }
    }
}
