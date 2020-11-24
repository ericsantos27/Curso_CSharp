using System;

namespace REV_Seção_6_Vetores_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRental[] dataRental = new ClassRental[10];

            Console.Write("Quantidade de quartos alugados: ");
            int roomQty = int.Parse(Console.ReadLine());

            for(int i = 1; i <= roomQty; i++)
            {
                Console.WriteLine("Aluguel {0}:", i);
                Console.Write("Nome: ");
                string tenantName = Console.ReadLine();
                Console.Write("Email: ");
                string tenantEmail = Console.ReadLine();
                Console.Write("Quarto: ");
                int room = int.Parse(Console.ReadLine());
                dataRental[room] = new ClassRental(tenantName, tenantEmail);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados: ");

            for(int i = 0; i < 10; i++)
            {
                if(dataRental[i] != null)
                {
                    Console.WriteLine("Quarto {0}: {1}", i, dataRental[i]);
                }
            }
        }
    }
}
