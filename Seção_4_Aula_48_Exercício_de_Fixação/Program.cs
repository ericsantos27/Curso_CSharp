using System;
using System.Globalization;

namespace Seção_4_Aula_48_Exercício_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CONVERSOR DE MOEDAS");
            Console.WriteLine();

            Console.Write("Cotação da moeda: ");
            ClassCurreuncyConverter.ExtRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de moeda: ");
            ClassCurreuncyConverter.CurQty = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double CurResult = ClassCurreuncyConverter.AddTax();

            Console.WriteLine("Valor: {0}", CurResult.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
