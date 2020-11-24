using System;

namespace Seção_4_Aula_42_Segundo_Problema_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassProduct prodEncapsulation = new ClassProduct("Television", 850.00, 10);

            Console.WriteLine(prodEncapsulation.GetName());

            prodEncapsulation.SetName("Television 4K");

            Console.WriteLine(prodEncapsulation.GetName());
        }
    }
}
