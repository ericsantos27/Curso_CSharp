using System;

namespace REV_Seção_5_This
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string personName = Console.ReadLine();
            Console.Write("Idade: ");
            int personAge = int.Parse(Console.ReadLine());
            Console.Write("Saldo: ");
            double bankBalance = double.Parse(Console.ReadLine());

            ClassThis bankClient = new ClassThis(personName, personAge, bankBalance);

            Console.WriteLine("Dados: {0}", bankClient);
        }
    }
}
