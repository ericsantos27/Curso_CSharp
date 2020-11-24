using System;

namespace Seção_4_Aula_40_Exercícios_01b
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWorker _worker1, _worker2;
            _worker1 = new ClassWorker();
            _worker2 = new ClassWorker();

            Console.WriteLine("Dados do funcionário 1:");
            Console.Write("Nome: ");
            _worker1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            _worker1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do funcionário 2:");
            Console.Write("Nome: ");
            _worker2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            _worker2.Salary = double.Parse(Console.ReadLine());

            double _medSalary = (_worker1.Salary + _worker2.Salary) / 2;

            Console.WriteLine("Salário médio: {0:F2}", _medSalary);
           
        }
    }
}
