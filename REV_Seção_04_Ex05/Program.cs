using System;

namespace REV_Seção_04_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasWorkerData workerData = new ClasWorkerData();
            
            Console.Write("Funcionário: ");
            workerData.WorkerName = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            workerData.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            workerData.TaxSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: {0}", workerData);

            Console.Write("Digite o percentual de aumento: ");
            double percentage = double.Parse(Console.ReadLine());
            workerData.IncreaseSalary(percentage);

            Console.WriteLine("Dados atualizados: {0}", workerData);
        }
    }
}
