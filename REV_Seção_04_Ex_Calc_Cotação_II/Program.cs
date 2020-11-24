using System;

namespace REV_Seção_04_Ex_Calc_Cotação_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPricing quotation = new ClassPricing();

            Console.Write("Cotação do dólar: ");
            double exchRate = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            double quantity = double.Parse(Console.ReadLine());

            double totalValue = quotation.Conversion(exchRate, quantity);

            Console.WriteLine("Valor calculado: {0:F2}", totalValue);
        }
    }
}
