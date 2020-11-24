using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Exercícios_Fixação_Ex_2
{
    class ClassWorkers
    {
        public string WorkName;
        public double WorkGrossSalary;
        public double WorkTax;

        public double NetSalary()
        {
            return WorkGrossSalary - WorkTax;
        }

        public void IncreaseSalary(double workGrossSalary)
        {
            double incSalary = ((WorkGrossSalary * workGrossSalary) / 100);
            WorkGrossSalary += incSalary;
        }

        public override string ToString()
        {
            return WorkName + ", $ " + NetSalary().ToString("F2");
        }
    }
}
