using System;

namespace Seção_3_Aula_35_Exercícios_Propostos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de repetições: ");
            int _num1 = int.Parse(Console.ReadLine());
            int _inInterval = 0;
            int _outInterval = 0;

            for (int _i = 1; _i <= _num1; _i++)
            {
                int _num2 = int.Parse(Console.ReadLine());
                if (_num2 >= 10 && _num2 <= 20)
                {
                    _inInterval = _inInterval + 1;
                }
                else if (_num2 < 10 || _num2 > 20)
                {
                    _outInterval = _outInterval + 1;
                }                
            }
            Console.WriteLine("{0} in", _inInterval);
            Console.WriteLine("{0} out", _outInterval);
        }
    }
}
