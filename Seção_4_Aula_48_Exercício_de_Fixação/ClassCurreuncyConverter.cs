using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_48_Exercício_de_Fixação
{
    class ClassCurreuncyConverter
    {
        public static double ExtRate;
        public static double CurQty;
        public static double IOF_Tax = 0.06;

        public static double ConversionCur()
        {
            return CurQty * ExtRate;
        }

        public static double AddTax()
        {
            return ConversionCur() + ((CurQty * ExtRate) * IOF_Tax);
        }
    }
}
