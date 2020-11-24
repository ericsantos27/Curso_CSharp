using System;

namespace Seção_6_Aula_73_Modificador_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número: ");
            int numb = int.Parse(Console.ReadLine());
            int triple;
            ClassOut.Triple(numb, out triple);
            Console.WriteLine(triple);
        }
    }
}
