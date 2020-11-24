using System;

namespace Seção_5_Aula_60_Exercício_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassBankAccount bankAccountData;

            Console.Write("Número da conta: ");
            int accNumb = int.Parse(Console.ReadLine());
            Console.Write("Titular: ");
            string bankHld = Console.ReadLine();
            Console.Write("Depósito inicial (S ou N): ");
            char ansInDep = char.Parse(Console.ReadLine());
            if (ansInDep == 'S')
            {
                Console.Write("Valor do depósito: ");
                double amount = double.Parse(Console.ReadLine());
                bankAccountData = new ClassBankAccount(accNumb, bankHld, amount);
            }
            else
            {
                bankAccountData = new ClassBankAccount(accNumb, bankHld);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: {0}", bankAccountData);

            Console.Write("Valor do depósito: ");
            double depAmount = double.Parse(Console.ReadLine());
            bankAccountData.cashDeposit(depAmount);

            Console.WriteLine("Dados da conta: {0}", bankAccountData);

            Console.Write("Valor do saque: ");
            double withAmount = double.Parse(Console.ReadLine());
            bankAccountData.cashWithdraw(withAmount);
            Console.WriteLine();

            Console.Write("Dados da conta: {0}", bankAccountData);

        }
    }
}
