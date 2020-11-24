using System;

namespace Seção_4_Aula_41_Reaproveitamento_e_Delegação
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTriangle Triangle_x, Triangle_y;
            Triangle_x = new ClassTriangle();
            Triangle_y = new ClassTriangle();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Triangle_x.tSide_A = double.Parse(Console.ReadLine());
            Triangle_x.tSide_B = double.Parse(Console.ReadLine());
            Triangle_x.tSide_C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            Triangle_y.tSide_A = double.Parse(Console.ReadLine());
            Triangle_y.tSide_B = double.Parse(Console.ReadLine());
            Triangle_y.tSide_C = double.Parse(Console.ReadLine());

            double Area_tx = Triangle_x.AreaTriangle();
            double Area_ty = Triangle_y.AreaTriangle();

            Console.WriteLine("Área do triângulo X: {0:F4}", Area_tx);
            Console.WriteLine("Área do triângulo Y: {0:F4}", Area_ty);

            if(Area_tx > Area_ty)
            {
                Console.WriteLine("O triângulo X tem a maior área");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem a maior área");
            }
        }
    }
}
