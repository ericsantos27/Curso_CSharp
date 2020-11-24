using System;

namespace Seção_3_Aula_33_Exercícios_Propostos_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int _alcool = 0;
            int _gasol = 0;
            int _diesel = 0;

            int _cod_Comb = int.Parse(Console.ReadLine());

            while (_cod_Comb != 4)
            {
                if (_cod_Comb == 1)
                {
                    _alcool = _alcool + 1;
                }
                if (_cod_Comb == 2)
                {
                    _gasol = _gasol + 1;
                }
                if (_cod_Comb == 3)
                {
                    _diesel = _diesel + 1;
                }
                _cod_Comb = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO !");
            Console.WriteLine("Alcool: {0}", _alcool);
            Console.WriteLine("Gasolina: {0}", _gasol);
            Console.WriteLine("Diesel: {0}", _diesel);
        }
    }
}
