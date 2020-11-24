using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_46_Membros_Estáticos_Parte_1_Ex1
{
    class ClassCalculator
    {
        public static double Pi = 3.14;
        public static double radius;

        public static double _Circumference()
        {
            return (2.0 * Pi) * radius;
        }

        public static double _Volume()
        {
            return (4.0 * Pi * (Math.Pow(radius, 3))) / 3;
        }
    }
}
