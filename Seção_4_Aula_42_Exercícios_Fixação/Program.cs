using System;

namespace Seção_4_Aula_42_Exercícios_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            RectangleClass mainRectangle = new RectangleClass();

            Console.WriteLine("Dados do retangulo: ");
            Console.Write("Largura: ");
            mainRectangle.widthRect = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            mainRectangle.heightRect = double.Parse(Console.ReadLine());

            double mainArea = mainRectangle.AreaRectangle();
            double mainPerimeter = mainRectangle.PerimeterRectangle();
            double mainDiagonal = mainRectangle.DiagonalRectangle();

            Console.WriteLine("Area = {0:F2}", mainArea);
            Console.WriteLine("Perímetro = {0:F2}", mainPerimeter);
            Console.WriteLine("Diagonal = {0:F2}", mainDiagonal);

        }
    }
}
