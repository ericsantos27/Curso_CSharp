using System;
using System.Runtime.Intrinsics.X86;

namespace Seção_7_Aula_88_Funções_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            /* Função Trim() apaga os espaços em branco na frente e no final da string */
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(5);
            string s5 = original.Substring(6, 5);
            /* Comando para substituir caracter */
            string s6 = original.Replace('a', 'x');
            /* comando para substituir string */
            string s7 = original.Replace("abc", "XY");
            /* Comando para testar se a string é nula ou vazia */
            bool b1 = string.IsNullOrEmpty(original);
            /* Comando para testar se a string é nula ou se é um espaço em branco */
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Texto original: {0}-", original);
            Console.WriteLine("Texto com função 'ToUpper()': {0}-", s1);
            Console.WriteLine("Texto com função 'ToLower()': {0}-", s2);
            Console.WriteLine("Texto com função 'Trim()': {0}-", s3);
            Console.WriteLine("Função 'IndexOf()': {0}", n1);
            Console.WriteLine("Função 'LastIndexOf()': {0}", n2);
            Console.WriteLine("Função 'Substring()': {0}", s4);
            Console.WriteLine("Função 'Substring(6, 5)': {0}", s5);
            Console.WriteLine("Texto com função 'Replace('a', 'x')': {0}-", s6);
            Console.WriteLine("Texto com função 'Replace('abc', 'XY')': {0}-", s7);
            Console.WriteLine("Teste função 'IsNullOrEmpty': {0}", b1);
            Console.WriteLine("Teste função 'IsNullOrWhiteSpace': {0}", b2);
        }
    }
}
