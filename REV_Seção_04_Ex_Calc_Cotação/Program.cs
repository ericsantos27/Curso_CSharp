using System;

namespace REV_Seção_04_Ex_Calc_Cotação
{
    class Program
    {
        static double iof = 0.06;
        static void Main(string[] args)
        {
            Console.Write("Cotação do dólar: ");
            double dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de dólares: ");
            double qty = double.Parse(Console.ReadLine());

            double valor = conversion(dolar, qty);

            Console.WriteLine("Valor em reais: {0:F2}", valor);
        }
        static double conversion(double money, double qtty)
        {
            double value = money * qtty;
            return (value * iof) + value; 
        }
    }
}
