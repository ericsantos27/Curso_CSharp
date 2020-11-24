using System;

namespace REV_Seção_04_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassStudent studentData = new ClassStudent();
            Console.Write("Nome do aluno: ");
            studentData.StudentName = Console.ReadLine();

            Console.WriteLine("Notas: ");
            Console.Write("1° trimestre: ");
            studentData.FstQuarterGde = double.Parse(Console.ReadLine());
            Console.Write("2° trimestre: ");
            studentData.ScdQuarterGde = double.Parse(Console.ReadLine());
            Console.Write("3° trimestre: ");
            studentData.TrdQuarterGde = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: {0:F2}", studentData.FinalGde());

            if (studentData.Approved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram {0:F2} pontos para aprovação", studentData.AftermathGde());
            }
        }
    }
}
