using System;

namespace Seção_3_Aula_22_Entrada_de_Dados_Pt._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escrever uma frase com quebra de linha (enter) e armazenar em uma variável //
            string frase = Console.ReadLine();
            Console.WriteLine();
            // Escrever na tela palavras em linhas diferentes //
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ele disse: {0}", frase);
            Console.WriteLine("Cor 1: {0}", x);
            Console.WriteLine("Cor 2: {0}", y);
            Console.WriteLine("Cor 3: {0}", z);
            Console.WriteLine();
            // Escrever comando split //
            string sr = Console.ReadLine();
            string[] vet = sr.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine();
            // OU //
            string[] vet2 = Console.ReadLine().Split(' ');
            string p4 = vet2[0];
            string p5 = vet2[1];
            string p6 = vet2[2];
            Console.WriteLine(p4);
            Console.WriteLine(p5);
            Console.WriteLine(p6);

        }
    }
}
