using System;

namespace Seção_4_Aula_39_Programa_com_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTriangulo t_x, t_y;
            t_x = new ClassTriangulo();
            t_y = new ClassTriangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            t_x.Side_a = double.Parse(Console.ReadLine());
            t_x.Side_b = double.Parse(Console.ReadLine());
            t_x.Side_c = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            t_y.Side_a = double.Parse(Console.ReadLine());
            t_y.Side_b = double.Parse(Console.ReadLine());
            t_y.Side_c = double.Parse(Console.ReadLine());

            double _px = p_Result(t_x.Side_a, t_x.Side_b, t_x.Side_c);
            double _py = p_Result(t_y.Side_a, t_y.Side_b, t_y.Side_c);

            double x_Root = Math.Sqrt(((_px - t_x.Side_a) * (_px - t_x.Side_b) * (_px - t_x.Side_c)) * _px);
            double y_Root = Math.Sqrt(((_py - t_y.Side_a) * (_py - t_y.Side_b) * (_py - t_y.Side_c)) * _py);

            Console.WriteLine("Área do triângulo X: {0:F4}", x_Root);
            Console.WriteLine("Área do triângulo Y: {0:F4}", y_Root);

            if (x_Root > y_Root)
            {
                Console.WriteLine("O triângulo X tem a maior área");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem a maior área");
            }
            
        }
        static double p_Result(double _a, double _b, double _c)
        {
            double _p = (_a + _b + _c) / 2;
            return _p;
        }
    }
}
