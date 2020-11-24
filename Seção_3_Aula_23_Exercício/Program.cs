using System;

namespace Seção_3_Aula_23_Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrar com nome completo//
            //Quantos quartos tem sua casa//
            //O preço de um produto//
            //Na mesma linha digite o último nome, idade e altura// 
            Console.Write("Nome: ");
            string personName = Console.ReadLine();
            int bedNumber = int.Parse(Console.ReadLine());
            double bedPrice = double.Parse(Console.ReadLine());
            string[] vet_a = Console.ReadLine().Split(' ');
            string lastName = vet_a[0];
            int personAge = int.Parse(vet_a[1]);
            float personHeight = float.Parse(vet_a[2]);
            Console.WriteLine("Nome: {0}", personName);
            Console.WriteLine("Número de quartos: {0}", bedNumber);
            Console.WriteLine("Preço: {0}", bedPrice);
            Console.WriteLine("Sobrenome: {0}", lastName);
            Console.WriteLine("Idade: {0}", personAge);
            Console.WriteLine("Altura: {0}", personHeight);

        }
    }
}
