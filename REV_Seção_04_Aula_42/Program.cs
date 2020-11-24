using System;

namespace REV_Seção_04_Aula_42
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassProduct productData = new ClassProduct();

            Console.Write("Nome: ");
            productData.ProductName = Console.ReadLine();
            Console.Write("Preço: ");
            productData.ProductPrice = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            productData.ProductQty = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: {0}", productData);

            Console.Write("Quantidade de produtos adicionadas: ");
            int qtyProduct = int.Parse(Console.ReadLine());
            productData.AddQtyPrd(qtyProduct);
            Console.WriteLine("Dados atualizados: {0}", productData);

            Console.Write("Quantidade de produtos removidas: ");
            qtyProduct = int.Parse(Console.ReadLine());
            productData.RemQtyPrd(qtyProduct);
            Console.WriteLine("Dados atualizados: {0}", productData);
        }
    }
}
