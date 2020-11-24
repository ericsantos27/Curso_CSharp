using System;

namespace Seção_6_Aula_73_Modificador_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numb = int.Parse(Console.ReadLine());
            ClassRef.Triple(ref numb);
            Console.WriteLine(numb);
        }
    }
}
