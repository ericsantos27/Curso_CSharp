using System;

namespace REV_Seção_04_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWorkers worker_1, worker_2;
            worker_1 = new ClassWorkers();
            worker_2 = new ClassWorkers();

            Console.WriteLine("Dados Funcionário 1: ");
            Console.Write("Nome: ");
            worker_1.workerName = Console.ReadLine();
            Console.Write("Salário: ");
            worker_1.workerSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados Funcionário 2: ");
            Console.Write("Nome: ");
            worker_2.workerName = Console.ReadLine();
            Console.Write("Salário: ");
            worker_2.workerSalary = double.Parse(Console.ReadLine());

            double salaryAVG = (worker_1.workerSalary + worker_2.workerSalary) / 2;

            Console.WriteLine("Salário médio: {0:F2}", salaryAVG);
        }
    }
}
