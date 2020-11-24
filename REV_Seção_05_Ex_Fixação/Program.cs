using System;

namespace REV_Seção_05_Ex_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            double bkBalance = 0.00;
            Console.Write("Digite o número da conta: ");
            int bkAccount = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string bkOwner = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S / N): ");
            string isDeposit = Console.ReadLine();
            if(isDeposit == "S")
            {
                Console.Write("Depósito inicial: ");
                double Balance = double.Parse(Console.ReadLine());
                bkBalance += Balance;
            }

            ClassBankAccount InfoBankAccount = new ClassBankAccount(bkAccount, bkOwner, bkBalance);
            Console.WriteLine();
            Console.WriteLine("Dados da conta: {0}", InfoBankAccount);
            Console.WriteLine();

            Console.Write("Valor de depósito: ");
            double depValue = double.Parse(Console.ReadLine());
            InfoBankAccount.BankDeposit(depValue);
            Console.WriteLine("Dados da conta: {0}", InfoBankAccount);
            Console.WriteLine();

            Console.Write("Valor de saque: ");
            double drtvalue = double.Parse(Console.ReadLine());
            InfoBankAccount.BankDraft(drtvalue);
            Console.WriteLine("Dados da conta: {0}", InfoBankAccount);
        }
    }
}
