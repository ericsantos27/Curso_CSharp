using System;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductClass product_a = new ProductClass();

            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            product_a.ProdName = Console.ReadLine();
            Console.Write("Preço: ");
            product_a.ProdPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            product_a.ProdQty = int.Parse(Console.ReadLine());

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
