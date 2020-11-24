using System;

namespace Seção_4_Aula_40_Exercícios_01b_b
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassEmployees employee_1, employee_2;
            employee_1 = new ClassEmployees();
            employee_2 = new ClassEmployees();

            Console.WriteLine("Funcionário 1");
            Console.Write("Nome: ");
            employee_1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee_1.Salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário 2");
            Console.Write("Nome: ");
            employee_2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            employee_2.Salary = double.Parse(Console.ReadLine());

            double med_Salary = (employee_1.Salary + employee_2.Salary) / 2;

            Console.WriteLine("Salário médio = {0:F2}", med_Salary);
        }
    }
}
