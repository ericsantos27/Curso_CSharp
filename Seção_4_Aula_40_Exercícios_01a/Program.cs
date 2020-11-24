using System;

namespace Seção_4_Aula_40_Exercícios_01a
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPeople _person1, _person2;
            _person1 = new ClassPeople();
            _person2 = new ClassPeople();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            _person1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            _person1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            _person2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            _person2.Age = int.Parse(Console.ReadLine());

            if (_person1.Age > _person2.Age)
            {
                Console.WriteLine("Pessoa mais velha: {0}", _person1.Name);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", _person2.Name);
            }
        }
    }
}
