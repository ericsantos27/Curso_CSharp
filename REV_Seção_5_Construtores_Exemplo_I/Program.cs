using System;

namespace REV_Seção_5_Construtores_Exemplo_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            string prdName = Console.ReadLine();
            Console.Write("Preço: ");
            double prdPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int prdQty = int.Parse(Console.ReadLine());

            ClassProduct ProductInfo = new ClassProduct(prdName, prdPrice, prdQty);

            Console.WriteLine("Dados do produto: {0}", ProductInfo);

            Console.Write("Quantidade adicionada ao estoque: ");
            int prdAdd = int.Parse(Console.ReadLine());
            ProductInfo.AddProdQty(prdAdd);

            Console.WriteLine("Dados atualizados: {0}", ProductInfo);

            Console.Write("Quantidade de baixa de estoque: ");
            int prdDed = int.Parse(Console.ReadLine());
            ProductInfo.DedProdQty(prdDed);

            Console.WriteLine("Dados atualizados: {0}", ProductInfo);
        }
    }
}
