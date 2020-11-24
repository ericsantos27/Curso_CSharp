using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Ex06
{
    class ClassStudData
    {
        public string StudName;
        public double FstQuartGrade;
        public double ScdQuartGrade;
        public double TrdQuartGrade;

        public double FinalGrade()
        {
            return FstQuartGrade + ScdQuartGrade + TrdQuartGrade;
        }

        public bool Approved()
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

        public double AftermathGrade()
        {
            if (Approved())
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
