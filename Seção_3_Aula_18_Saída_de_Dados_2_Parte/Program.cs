using System;

namespace Seção_3_Aula_18_Saída_de_Dados_2_Parte
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 39;
            double banc_bal = 28150.459120;
            string name = "Eric Santos";
            Console.WriteLine("O saldo da conta do cliente {0} de {1} anos de idade é de {2:F2} reais.", name, age, banc_bal);

            Console.WriteLine("____________________________________________________________________________________________________");

            Console.WriteLine($"O saldo da conta do cliente {name} de {age} anos de idade é de {banc_bal:F2} reais.");
        }
    }
}
