using System;

namespace Seção_4_Aula_41_Reaproveitamento_e_Delegação
{
    class ClassTriangle
    {
        public double tSide_A;
        public double tSide_B;
        public double tSide_C;

        public double AreaTriangle()
        {
            double _pTriangle = (tSide_A + tSide_B + tSide_C) / 2.0;
            double rootTriangle = Math.Sqrt(((_pTriangle - tSide_A) * (_pTriangle - tSide_B) * (_pTriangle - tSide_C)) * _pTriangle);
            return rootTriangle;
        }

    }
}
