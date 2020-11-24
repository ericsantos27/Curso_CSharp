using System;

namespace Seção_4_Aula_42_Exercícios_Fixação_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassStudent studentData = new ClassStudent();

            Console.Write("ALUNO: ");
            studentData.StudentName = Console.ReadLine();

            Console.WriteLine("NOTAS DO ALUNO:");
            studentData.FstQuarterGrade = double.Parse(Console.ReadLine());
            studentData.ScdQuarterGrade = double.Parse(Console.ReadLine());
            studentData.TrdQuarterGrade = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = {0:F2}", studentData.FinalGrade());

            Console.WriteLine();
            if (studentData.Aproved())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0:F2} PONTOS", studentData.AfterMathGrade());
            }
        }
    }
}
