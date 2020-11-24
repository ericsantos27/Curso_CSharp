using System;

namespace Seção_3_Aula_29_Exercícios_Propostos_Parte_2_Exercício_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
             * 0.00 até 2000.00    = isento
             * 2000.01 até 3000.00 = 8%
             * 3000.01 até 4500.00 = 18%
             * acima de 4500.00    = 28%
             * 
             * Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda
             */

            double _amountEarn = double.Parse(Console.ReadLine());

            double _basisCalc = _amountEarn - 2000.00;

            double _result;
            
            if (_basisCalc <= 0.00)
            {
                Console.WriteLine("ISENTO");
            }
            else if (_basisCalc > 0.00 && _basisCalc <= 1000.00)
            {
                _result = _basisCalc * 0.08;
                Console.WriteLine("R$ {0:F2}", _result);
            }
            else if (_basisCalc > 1000.00 && _basisCalc <= 1500.00)
            {
                _result = ((_amountEarn - 3000.00) * 0.18) + 80.00;
                Console.WriteLine("R$ {0:F2}", _result);
            }
            else if (_basisCalc > 1500.00)
            {
                _result = ((_amountEarn - 4500.00) * 0.28) + 350.00;
                Console.WriteLine("R$ {0:F2}", _result);
            }
        }
    }
}
