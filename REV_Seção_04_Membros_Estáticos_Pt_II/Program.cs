using System;

namespace REV_Seção_04_Membros_Estáticos_Pt_II
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCalculation calc = new ClassCalculation();

            Console.Write("Valor do raio: ");
            double ray = double.Parse(Console.ReadLine());

            calc.circunference(ray);
            calc.volum(ray);

            Console.WriteLine("Circunferência: {0:F2}", calc.circunference(ray));
            Console.WriteLine("Volume: {0:F2}", calc.volum(ray));
            Console.WriteLine("Valor de pi: 3,14");
        }
    }
}
