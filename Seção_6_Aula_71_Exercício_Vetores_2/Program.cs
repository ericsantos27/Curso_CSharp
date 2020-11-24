using System;

namespace Seção_6_Aula_71_Exercício_Vetores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRental[] dataRental = new ClassRental[10];

            Console.Write("Quantidade de quartos alugados: ");
            int roomQty = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 0; i < roomQty; i++)
            {
                Console.WriteLine("Aluguel #{0}", i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Número do quarto: ");
                int room = int.Parse(Console.ReadLine());
                dataRental[room] = new ClassRental(name, email);
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Quartos alugados: ");
            for(int i = 0; i < 10; i++)
            {
                if (dataRental[i] != null)
                {
                    Console.WriteLine(i + " : " + dataRental[i]);
                }
            }
        }
    }
}
