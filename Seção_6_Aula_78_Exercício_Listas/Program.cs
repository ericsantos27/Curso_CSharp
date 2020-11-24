using System;
using System.Globalization;
using System.Collections.Generic;

namespace Seção_6_Aula_78_Exercício_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de funcionários: ");
            int workerNumb = int.Parse(Console.ReadLine());

            List<WorkerClass> workerList = new List<WorkerClass>();

            for(int i = 1; i <= workerNumb; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Dados do funcionário #{0}:", i);
                Console.Write("ID: ");
                int Id_aux = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string Name_aux = Console.ReadLine();
                Console.Write("Salário: ");
                double Salary_aux = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                workerList.Add(new WorkerClass(Id_aux, Name_aux, Salary_aux));
            }
            Console.WriteLine();
            Console.Write("ID do funcionário para aumento de salário: ");
            int searchId = int.Parse(Console.ReadLine());

            WorkerClass empId = workerList.Find(x => x.workerId == searchId);

            if(empId != null)
            {
                Console.WriteLine();
                Console.Write("Digite o percentual de aumento: ");
                int percentIncrease = int.Parse(Console.ReadLine());
                empId.incSalary(percentIncrease);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Este ID não existe");
                Console.WriteLine();
            }

            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (WorkerClass element in workerList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
