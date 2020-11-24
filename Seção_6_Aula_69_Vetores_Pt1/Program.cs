using System;
using System.Globalization;

namespace Seção_6_Aula_69_Vetores_Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of people: ");
            int numb = int.Parse(Console.ReadLine());
             
            double[] vect = new double[numb];

            for(int i = 0; i < numb; i++)
            {
                Console.Write("Height: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < numb; i++)
            {
                sum += vect[i];
            }

            double avg = sum / numb;

            Console.WriteLine("AVERAGE HEIGHT = {0:F2}", avg);
        }
    }
}
