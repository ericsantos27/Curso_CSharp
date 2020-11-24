using System;

namespace Seção_3_Aula_30_Funções_Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _3Numb = Console.ReadLine().Split(' ');

            int numb_1 = int.Parse(_3Numb[0]);
            int numb_2 = int.Parse(_3Numb[1]);
            int numb_3 = int.Parse(_3Numb[2]);

            if (numb_1 > numb_2 && numb_1 > numb_3)
            {
                Console.WriteLine("Maior = {0}", numb_1);
            }
            else if (numb_2 > numb_1 && numb_2 > numb_3)
            {
                Console.WriteLine("Maior = {0}", numb_2);
            }
            else
            {
                Console.WriteLine("Maior = {0}", numb_3);
            }

            /* Utilizando uma função em vez de if e else */

            string[] _3Numb_2 = Console.ReadLine().Split(' ');

            int numb_4 = int.Parse(_3Numb_2[0]);
            int numb_5 = int.Parse(_3Numb_2[1]);
            int numb_6 = int.Parse(_3Numb_2[2]);

            int _Bigger = Maior(numb_4, numb_5, numb_6);
            Console.WriteLine("Maior = {0}", _Bigger);
        }

        static int Maior(int _a, int _b, int _c)
        {
            int _m;
            if (_a > _b && _a > _c)
            {
                _m = _a;
            }
            else if (_b > _c)
            {
                _m = _b;
            }
            else
            {
                _m = _c;
            }
            return _m;
        }

    }
}
