using System;

namespace Seção_3_Aula_23_Entrada_de_Dados_P._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão de string em int (Console.Readline só lê string). Usar o comando int.Parse //
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: {0}", n1);

            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2);

            Console.WriteLine();

            Console.Write("Digite seu nome, gênero, idade e peso: ");
            string[] vet_1 = Console.ReadLine().Split(' ');
            string name = vet_1[0];
            char gen = char.Parse(vet_1[1]);
            int age = int.Parse(vet_1[2]);
            double height = double.Parse(vet_1[3]);
            Console.WriteLine("Variável 'name': {0}", name);
            Console.WriteLine("Variável 'gen': {0}", gen);
            Console.WriteLine("Variável 'age': {0}", age);
            Console.WriteLine("Variável 'height': {0:F2}", height);
            
        }
    }
}
