using System;

namespace Seção_6_Aula_71_Exercício_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTenant[] vectRoom = new ClassTenant[10];

            Console.Write("Quartos alugados: ");
            int rentalRooms = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rentalRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}: ", i);
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                vectRoom[room] = new ClassTenant(name, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if (vectRoom[i] != null)
                {
                    Console.WriteLine(i + " : " + vectRoom[i]);
                }
            }
        }
    }
}
