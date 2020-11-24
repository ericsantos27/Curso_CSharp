using System;

namespace REV_Seção_04_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPerson person_1, person_2;
            person_1 = new ClassPerson();
            person_2 = new ClassPerson();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            person_1.personName = Console.ReadLine();
            Console.Write("Idade: ");
            person_1.personAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            person_2.personName = Console.ReadLine();
            Console.Write("Idade: ");
            person_2.personAge = int.Parse(Console.ReadLine());

            if(person_1.personAge > person_2.personAge)
            {
                Console.WriteLine("Pessoa mais velha: {0}", person_1.personName);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: {0}", person_2.personName);
            }
        }
    }
}
