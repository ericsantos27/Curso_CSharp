using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_5_This
{
    class ClassThis
    {
        public string name;
        public int age;
        public double balance;

        public ClassThis(string name, int age, double balance)
        {
            this.name = name;
            this.age = age;
            this.balance = balance;
        }

        public override string ToString()
        {
            return "Cliente: " + name + "; Idade: " + age + "; Saldo: " + balance;
        }
    }
}
