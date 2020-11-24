using System;

namespace REV_Seção_7_Exp_Cond_Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço: ");
            double price = double.Parse(Console.ReadLine());
            double discount = (price < 200.00) ? price * 0.1 : price * 0.05;
            Console.WriteLine("Desconto concedido: {0:F2}", discount);

        }
    }
}
