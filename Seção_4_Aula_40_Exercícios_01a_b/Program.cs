using System;

namespace Seção_4_Aula_40_Exercícios_01a_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_People person_1, person_2;
            person_1 = new Class_People();
            person_2 = new Class_People();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            person_1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person_1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            person_2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            person_2.Age = int.Parse(Console.ReadLine());

            if(person_1.Age > person_2.Age)
            {
                Console.WriteLine("Pessoa mais velha: {0}", person_1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", person_2.Name);
            }
        }
    }
}
