using System;

namespace REV_Sessão_4_Aula_39
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTriangle tr_X, tr_Y;
            tr_X = new ClassTriangle();
            tr_Y = new ClassTriangle();

            Console.WriteLine("Digite os valores do triângulo X: ");
            tr_X.Side_A = double.Parse(Console.ReadLine());
            tr_X.Side_B = double.Parse(Console.ReadLine());
            tr_X.Side_C = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os valores do triângulo Y: ");
            tr_Y.Side_A = double.Parse(Console.ReadLine());
            tr_Y.Side_B = double.Parse(Console.ReadLine());
            tr_Y.Side_C = double.Parse(Console.ReadLine());

            double p_tr_X = P_Result(tr_X.Side_A, tr_X.Side_B, tr_X.Side_C);
            double p_tr_Y = P_Result(tr_Y.Side_A, tr_Y.Side_B, tr_Y.Side_C);

            double tr_XRoot = Math.Sqrt(((p_tr_X - tr_X.Side_A) * (p_tr_X - tr_X.Side_B) * (p_tr_X - tr_X.Side_C)) * p_tr_X);
            double tr_YRoot = Math.Sqrt(((p_tr_Y - tr_Y.Side_A) * (p_tr_Y - tr_Y.Side_B) * (p_tr_Y - tr_Y.Side_C)) * p_tr_Y);

            Console.WriteLine("Área do triângulo X: {0:F4}", tr_XRoot);
            Console.WriteLine("Área do triângulo Y: {0:F4}", tr_YRoot);

            if(tr_XRoot > tr_YRoot)
            {
                Console.WriteLine("O triângulo X tem a maior área");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem a maior área");
            }
        }

        static double P_Result(double _a, double _b, double _c)
        {
            double _p = (_a + _b + _c) / 2.0;
            return _p;
        }
    }
}
