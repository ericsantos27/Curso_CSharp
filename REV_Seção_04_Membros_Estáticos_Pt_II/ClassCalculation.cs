using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Membros_Estáticos_Pt_II
{
    class ClassCalculation
    {
        public double pi = 3.14;
        
        public double circunference(double r)
        {
            return 2.0 * pi * r;
        }
        public double volum(double r)
        {
            return ((4.0 / 3.0) * pi) * Math.Pow(r, 3);
        }
    }
}
