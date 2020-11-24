using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_5_Aula_60_Exercício_Fixação
{
    class ClassBankAccount
    {
        public double BankAmount { get; private set; }
        public int AccountNumber { get; private set; }
        public string BankHolder { get; set; }

        public ClassBankAccount(int account, string holder)
        {
            AccountNumber = account;
            BankHolder = holder;
        }

        public ClassBankAccount(int account, string holder, double amount) : this(account, holder)
        {
            BankAmount = amount;
        }

        public void cashDeposit(double _bankAmount)
        {
            BankAmount += _bankAmount;
        }

        public void cashWithdraw(double _bankAmount)
        {
            BankAmount -= _bankAmount + 5.0;
        }

        public override string ToString()
        {
            return "Conta: " + AccountNumber + " - Titular: " + BankHolder + " - Saldo: $" + BankAmount.ToString("F2");
        }
    }
}
