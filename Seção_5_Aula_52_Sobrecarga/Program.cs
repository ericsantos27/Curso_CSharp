using System;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());

            ClassProduct product_a = new ClassProduct(name, price);

            Console.WriteLine("Dados do produto: {0}", product_a);

            Console.WriteLine();

            Console.Write("Quantidade adicional: ");
            int qtyProduct = int.Parse(Console.ReadLine());
            product_a.AddProdQty(qtyProduct);
            Console.WriteLine();
            Console.WriteLine("Saldo Atual: {0}", product_a);

            Console.WriteLine();

            Console.Write("Quantidade removida: ");
            qtyProduct = int.Parse(Console.ReadLine());
            product_a.RemProdQty(qtyProduct);
            Console.WriteLine();
            Console.WriteLine("Saldo Atual: {0}", product_a);

        }
    }
}
