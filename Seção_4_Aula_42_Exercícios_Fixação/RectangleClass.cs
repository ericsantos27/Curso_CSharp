using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_4_Aula_42_Exercícios_Fixação
{
    class RectangleClass
    {
        public double widthRect;
        public double heightRect;

        public double AreaRectangle()
        {
            return widthRect * heightRect;
        }

        public double PerimeterRectangle()
        {
            return (widthRect + heightRect) * 2;
        }

        public double DiagonalRectangle()
        {
            return Math.Sqrt(Math.Pow(widthRect, 2) + Math.Pow(heightRect, 2));
        }
    }
   
}
