using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Ex03
{
    class ClassStudent
    {
        public string StudentName;
        public double FstQuarterGde;
        public double ScdQuarterGde;
        public double TrdQuarterGde;

        public double FinalGde()
        {
            return FstQuarterGde + ScdQuarterGde + TrdQuarterGde;
        }

        public bool Approved()
        {
            if(FinalGde() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AftermathGde()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalGde();
            }
        }
    }
}
