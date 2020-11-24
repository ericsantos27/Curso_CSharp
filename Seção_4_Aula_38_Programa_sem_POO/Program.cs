using System;

namespace Seção_4_Aula_38_Programa_sem_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com as medidas do triângulo X: ");
            string[] vl_TrgX = Console.ReadLine().Split(' ');
            double x_SideA = double.Parse(vl_TrgX[0]);
            double x_SideB = double.Parse(vl_TrgX[1]);
            double x_SideC = double.Parse(vl_TrgX[2]);

            Console.Write("Entre com as medidas do triângulo Y: ");
            string[] vl_TrgY = Console.ReadLine().Split(' ');
            double y_SideA = double.Parse(vl_TrgY[0]);
            double y_SideB = double.Parse(vl_TrgY[1]);
            double y_SideC = double.Parse(vl_TrgY[2]);

            double _px = p_Result(x_SideA, x_SideB, x_SideC);
            double _py = p_Result(y_SideA, y_SideB, y_SideC);

            double p_SumX = ((_px - x_SideA) * (_px - x_SideB) * (_px - x_SideC)) * _px;
            double p_SumY = ((_py - y_SideA) * (_py - y_SideB) * (_py - y_SideC)) * _py;

            double x_Root = Math.Sqrt(p_SumX);
            double y_Root = Math.Sqrt(p_SumY);

            Console.WriteLine("Área de X = {0:F4}", x_Root);
            Console.WriteLine("Área de Y = {0:F4}", y_Root);

            if (x_Root > y_Root)
            {
                Console.WriteLine("Maior área é: X");
            }
            else
            {
                Console.WriteLine("Maior área é: Y");
            }
        }

        static double p_Result(double _a, double _b, double _c)
        {
            double _p = (_a + _b + _c) / 2;
            return _p;
        }

         
        
    }
}
