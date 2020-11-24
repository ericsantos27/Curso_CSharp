using System;
using System.Globalization;

namespace Seção_3_Aula_18_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            string AF_1 = "Notebook Dell Vostro";
            string AF_2 = "Homework Desk Riccó";
            byte age = 30;
            int code = 5290;
            char gen = 'M';
            double price1 = 2100.00;
            double price2 = 650.50;
            double size = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}: Preço $ {1}", AF_1, price1);
            Console.WriteLine("{0}: Preço $ {1}", AF_2, price2);
            Console.WriteLine("Idade: {0}", age);
            Console.WriteLine("Código: {0}", code);
            Console.WriteLine("Gênero: {0}", gen);
            Console.WriteLine("Medida 8 casas: {0:F8}", size);
            Console.WriteLine("Medida 3 casas: {0:F3}", size);
            Console.WriteLine("Medida IC:" + size.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
