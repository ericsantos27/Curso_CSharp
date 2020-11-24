using System;
using System.Collections.Generic;
using System.Text;

namespace REV_Seção_04_Ex04
{
    class ClassRectangle
    {
        public double rectWidth;
        public double rectHeight;

        public double areaRectangle()
        {
            return rectWidth * rectHeight;
        }
        public double perimRectangle()
        {
            return (rectWidth + rectHeight) * 2;
        }
        public double diagRectangle()
        {
            return Math.Sqrt((Math.Pow(rectWidth, 2)) + (Math.Pow(rectHeight, 2)));
        }

    }
}
