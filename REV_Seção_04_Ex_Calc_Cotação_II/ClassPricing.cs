using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Ex_Calc_Cotação_II
{
    class ClassPricing
    {
        public double Conversion(double quote, double qty)
        {
            double value = qty * quote;
            return (value * 0.06) + value;
        }
    }
}
