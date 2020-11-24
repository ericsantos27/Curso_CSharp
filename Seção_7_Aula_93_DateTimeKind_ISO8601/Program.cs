using System;

namespace Seção_7_Aula_93_DateTimeKind_ISO8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2020, 01, 15, 23, 31, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2020, 01, 15, 23, 31, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2020, 01, 15, 23, 31, 58);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine();

            /* Utilizando as funções "ToLocalTime() para mostrar o horário local e a função "ToUniversalTime()" para mostrar o horário universal GMT */
            Console.WriteLine("D1: {0}", d1);
            Console.WriteLine("D1 Kind: {0}", d1.Kind);
            Console.WriteLine("D1 to local time: {0}", d1.ToLocalTime());
            Console.WriteLine("D1 to universal time: {0}", d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D2: {0}", d2);
            Console.WriteLine("D2 Kind: {0}", d2.Kind);
            Console.WriteLine("D2 to local time: {0}", d2.ToLocalTime());
            Console.WriteLine("D2 to universal time: {0}", d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D3: {0}", d3);
            Console.WriteLine("D3 Kind: {0}", d3.Kind);
            Console.WriteLine("D3 to local time: {0}", d3.ToLocalTime());
            Console.WriteLine("D3 to universal time: {0}", d3.ToUniversalTime());

            Console.WriteLine();

            /* Utilizando o formato padrão do ISO8601 */

            DateTime d4 = DateTime.Parse("2020-08-06 08:05:25");
            /* Padrão ISO8601 */
            DateTime d5 = DateTime.Parse("2020-08-06T08:05:25Z");
            Console.WriteLine();
            Console.WriteLine("D4: {0}", d4);
            Console.WriteLine("D4 kind: {0}", d4.Kind);
            Console.WriteLine("D4 to local time: {0}", d4.ToLocalTime());
            Console.WriteLine("D4 to universal time: {0}", d4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D5: {0}", d5);
            Console.WriteLine("D5 kind: {0}", d5.Kind);
            Console.WriteLine("D5 to local time: {0}", d5.ToLocalTime());
            Console.WriteLine("D5 to universal time: {0}", d5.ToUniversalTime());
            Console.WriteLine();
            /* Imprimindo o horário com o ToString */
            Console.WriteLine("Imprimindo com 'ToString': {0}", d5.ToString("yyyy-MM-ddThh:MM:ssZ"));
            /* Forma correta de utilizar o ToString */
            Console.WriteLine("Imprimindo com 'ToString'(correto): {0}", d5.ToUniversalTime().ToString("yyyy-MM-ddThh:MM:ssZ"));


        }
    }
}
