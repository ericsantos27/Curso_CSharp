using System;

namespace Sessão_3_Aula_32_Exercícios_Propostos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a senha: ");
            int _pass = int.Parse(Console.ReadLine());
            
            while (_pass != 2002)
            {
                Console.WriteLine("Senha incorreta");
                Console.Write("Digite a senha: ");
                _pass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
        }
    }
}
