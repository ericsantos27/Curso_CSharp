using System;

namespace Seção_4_Aula_39b_Programa_com_POO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Triangulo Triangle_x, Triangle_y;
            Triangle_x = new Class_Triangulo();
            Triangle_y = new Class_Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Triangle_x.Tlado_A = double.Parse(Console.ReadLine());
            Triangle_x.Tlado_B = double.Parse(Console.ReadLine());
            Triangle_x.Tlado_C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            Triangle_y.Tlado_A = double.Parse(Console.ReadLine());
            Triangle_y.Tlado_B = double.Parse(Console.ReadLine());
            Triangle_y.Tlado_C = double.Parse(Console.ReadLine());

            double p_Trianglex = p_Result(Triangle_x.Tlado_A, Triangle_x.Tlado_B, Triangle_x.Tlado_C);
            double p_Triangley = p_Result(Triangle_y.Tlado_A, Triangle_y.Tlado_B, Triangle_y.Tlado_C);

            double x_root = Math.Sqrt(((p_Trianglex - Triangle_x.Tlado_A) * (p_Trianglex - Triangle_x.Tlado_B) * (p_Trianglex - Triangle_x.Tlado_C)) * p_Trianglex);
            double y_root = Math.Sqrt(((p_Triangley - Triangle_y.Tlado_A) * (p_Triangley - Triangle_y.Tlado_B) * (p_Triangley - Triangle_y.Tlado_C)) * p_Triangley);

            Console.WriteLine("Área do triângulo X: {0:F4}", x_root);
            Console.WriteLine("Área do triângulo Y: {0:F4}", y_root);

            if(x_root > y_root)
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
            double _p = (_a + _b + _c) / 2.0;
            return _p;
        }
    }
}
