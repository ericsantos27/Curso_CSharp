using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Ex05
{
    class ClasWorkerData
    {
        public string WorkerName;
        public double GrossSalary;
        public double TaxSalary;

        public double NetSalary()
        {
            return GrossSalary - TaxSalary;
        }

        public void IncreaseSalary(double percent)
        {
            double percentIncrease = (percent / 100) * GrossSalary; 
            GrossSalary += percentIncrease;
        }
        public override string ToString()
        {
            return WorkerName + ", $ " + NetSalary().ToString("F2");
        }
    }
}
