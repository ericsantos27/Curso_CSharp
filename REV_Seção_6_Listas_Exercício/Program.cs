using System;
using System.Collections.Generic;

namespace REV_Seção_6_Listas_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Funcionáros para registro: ");
            int empNumber = int.Parse(Console.ReadLine());

            List<ClassWorkers> workerList = new List<ClassWorkers>();

            for(int i = 1; i <= empNumber; i++ )
            {
                Console.WriteLine("Dados do funcionário {0}: ", i);
                Console.Write("ID: ");
                int wkId = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string wkName = Console.ReadLine();
                Console.Write("Salário: ");
                double wkSalary = double.Parse(Console.ReadLine());
                workerList.Add(new ClassWorkers(wkId, wkName, wkSalary));
                Console.WriteLine();
            }

            Console.Write("ID do funcionário para aumento: ");
            int findId = int.Parse(Console.ReadLine());
            ClassWorkers idSal = workerList.Find(x => x.WorkerId == findId);

            if(idSal != null )
            {
                Console.Write("Percentual de aumento: ");
                double incPct = double.Parse(Console.ReadLine());
                idSal.increaseSalary(incPct);
            }
            else
            {
                Console.WriteLine("ID inexistente");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach(ClassWorkers element in workerList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
