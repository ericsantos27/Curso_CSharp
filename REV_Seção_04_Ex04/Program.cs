using System;

namespace REV_Seção_04_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRectangle rectangle = new ClassRectangle();

            Console.WriteLine("Entre com os dados do retângulo: ");
            Console.Write("Altura: ");
            rectangle.rectHeight = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            rectangle.rectWidth = double.Parse(Console.ReadLine());

            double areaRect = rectangle.areaRectangle();
            double perimRect = rectangle.perimRectangle();
            double diagRect = rectangle.diagRectangle();

            Console.WriteLine("AREA: {0:F2}", areaRect);
            Console.WriteLine("PERIMETRO: {0:F2}", perimRect);
            Console.WriteLine("DIAGONAL: {0:F2}", diagRect);

        }
    }
}
