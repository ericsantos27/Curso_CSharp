using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Exercícios_Fixação_Ex_3
{
    class ClassStudent
    {
        public string StudentName;
        public double FstQuarterGrade;
        public double ScdQuarterGrade;
        public double TrdQuarterGrade;

        public double FinalGrade()
        {
            return FstQuarterGrade + ScdQuarterGrade + TrdQuarterGrade;
        }

        public bool Aproved()
        {
            if (FinalGrade() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double AfterMathGrade()
        {
            if (Aproved())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - FinalGrade();
            }
        }

    }
}
