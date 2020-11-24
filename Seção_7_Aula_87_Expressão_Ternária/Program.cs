using System;

namespace Seção_7_Aula_87_Expressão_Ternária
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Código utilizando 'if/else'");
            Console.WriteLine();

            Console.Write("Digite o preço: ");
            double price = double.Parse(Console.ReadLine());
            double discount;
            if(price < 200.0)
            {
                discount = price * 0.1;
            }
            else
            {
                discount = price * 0.05;
            }
            Console.WriteLine("Desconto: {0:F2}", discount);
            Console.WriteLine();

            Console.WriteLine("Código utilizando expressão condicional ternária");
            Console.WriteLine();

            Console.Write("Digite o preço: ");
            double price2 = double.Parse(Console.ReadLine());
            double discount2 = (price2 < 200.0) ? price2 * 0.1 : price2 * 0.05;
            Console.WriteLine("Desconto: {0:F2}", discount2);
        }
    }
}
