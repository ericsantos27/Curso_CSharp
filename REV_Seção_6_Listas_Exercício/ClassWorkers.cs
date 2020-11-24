using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_6_Listas_Exercício
{
    class ClassWorkers
    {
        public int WorkerId { get; private set; }
        public string WorkerName { get; private set; }
        public double WorkerSalary { get; private set; }

        public ClassWorkers(int id, string name, double salary)
        {
            WorkerId = id;
            WorkerName = name;
            WorkerSalary = salary;
        }

        public void increaseSalary(double sal)
        {
            WorkerSalary += ((WorkerSalary * sal) / 100);
        }
        public override string ToString()
        {
            return WorkerId + ": " + WorkerName + "; " + WorkerSalary;
        }
    }
}
