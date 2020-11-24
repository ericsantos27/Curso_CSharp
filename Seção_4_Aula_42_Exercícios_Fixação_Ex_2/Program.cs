using System;

namespace Seção_4_Aula_42_Exercícios_Fixação_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWorkers salaryWorker = new ClassWorkers();

            Console.Write("Funcionário: ");
            salaryWorker.WorkName = Console.ReadLine();
            Console.Write("Salário bruto: ");
            salaryWorker.WorkGrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            salaryWorker.WorkTax = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: {0}", salaryWorker);
            Console.WriteLine();

            Console.Write("Percentual de aumento: ");
            double percentvalue = double.Parse(Console.ReadLine());
            salaryWorker.IncreaseSalary(percentvalue);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: {0}", salaryWorker);

        }
    }
}
