using System;

namespace REV_Seção_5_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string prdName = Console.ReadLine();
            Console.Write("Preço: ");
            double prdPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int prdQty = int.Parse(Console.ReadLine());

            ClassProduct InventProduct = new ClassProduct(prdName, prdPrice, prdQty);

            Console.WriteLine();
            Console.WriteLine("Dados de estoque: {0}", InventProduct);
            Console.WriteLine();
            Console.Write("Adicionar quantidade: ");
            int prdAdd = int.Parse(Console.ReadLine());
            InventProduct.AddQty(prdAdd);
            Console.WriteLine();
            Console.WriteLine("Dados de estoque: {0}", InventProduct);
            Console.WriteLine();
            Console.Write("Remover quantidade: ");
            int prdRem = int.Parse(Console.ReadLine());
            InventProduct.RemQty(prdRem);
            Console.WriteLine();
            Console.WriteLine("Dados de estoque: {0}", InventProduct);
        }
    }
}
