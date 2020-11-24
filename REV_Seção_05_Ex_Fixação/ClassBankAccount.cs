using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_05_Ex_Fixação
{
    class ClassBankAccount
    {
        public int BankAccount { get; private set; }
        public string BankOwner { get; set; }
        public double AccountBalance { get; private set; }
        public ClassBankAccount(int account, string owner, double balance)
        {
            BankAccount = account;
            BankOwner = owner;
            AccountBalance = balance;
        }

        public void BankDeposit(double deposit)
        {
            AccountBalance += deposit;
        }
        public void BankDraft(double draft)
        {
            double draftRate = 5.00;
            AccountBalance -= (draft + draftRate);
        }
        public override string ToString()
        {
            return "Conta: " + BankAccount + "; Titular: " + BankOwner + "; Saldo: $ " + AccountBalance.ToString("F2");
        }
    }
}
