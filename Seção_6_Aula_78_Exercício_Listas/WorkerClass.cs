using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Seção_6_Aula_78_Exercício_Listas
{
    class WorkerClass
    {
        public int workerId { get; private set; }
        public string workerName { get; private set; }
        public double workerSalary { get; private set; }

        public WorkerClass(int wkId, string wkName, double wkSalary)
        {
            workerId = wkId;
            workerName = wkName;
            workerSalary = wkSalary;
        }

        public void incSalary(double salary)
        {
            workerSalary += workerSalary * salary / 100;
        }

        public override string ToString()
        {
            return workerId + ", " + workerName + ", " + workerSalary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
