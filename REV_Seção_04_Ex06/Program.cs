using System;

namespace REV_Seção_04_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassStudData studentData = new ClassStudData();

            Console.Write("Nome do aluno: ");
            studentData.StudName = Console.ReadLine();
            Console.Write("1° trimestre: ");
            studentData.FstQuartGrade = double.Parse(Console.ReadLine());
            Console.Write("2° trimestre: ");
            studentData.ScdQuartGrade = double.Parse(Console.ReadLine());
            Console.Write("3° trimestre: ");
            studentData.TrdQuartGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: {0:F2}", studentData.FinalGrade());

            if(studentData.Approved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0:F2} PONTOS", studentData.AftermathGrade());
            }
        }
    }
}
