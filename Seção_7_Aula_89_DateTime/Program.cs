using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace Seção_7_Aula_89_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Comando para pegar o instante atual do sistema */
            DateTime d1 = DateTime.Now;
            Console.WriteLine("Horário atual: {0}", d1);
            /* Comando para imprimir a quantidade de ticks da data consultada. Unidade do .NET para datas. Cada tick equivale a 100 nanosegundos */
            Console.WriteLine("Quantidade de ticks: {0}", d1.Ticks);
            Console.WriteLine();
            Console.WriteLine("TRABALHANDO COM CONSTRUTORES");
            Console.WriteLine();
            /* Construtor para imprimir uma data às zero horas */
            DateTime d2 = new DateTime(2020, 08, 04);
            Console.WriteLine("Construtor d2: {0}", d2);
            /* Construtor para especificar um horário */
            DateTime d3 = new DateTime(2020, 08, 03, 22, 31, 43);
            Console.WriteLine("Construtor d3: {0}", d3);
            /* Comando 'DateTime.Today' trás a data atual às zero horas */
            DateTime d4 = DateTime.Today;
            Console.WriteLine("Comando 'DateTime.Today': {0}", d4);
            /* Comando para pegar o horário UTC que é o horário universal de Greenwich */
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine("Comando 'DateTime.UtcNow: {0}", d5);
            Console.WriteLine();
            /* Utilizando DateTime com Parse */
            /* Utilizando o formato de data de banco de dados */
            DateTime d6 = DateTime.Parse("2020-08-04");
            Console.WriteLine("Parse com formato de banco de dados: {0}", d6);
            /* DateTime com horário */
            DateTime d7 = DateTime.Parse("2020-08-04 06:54:22");
            Console.WriteLine("Parse com data e horário: {0}", d7);
            /* DateTime no formato brasileiro */
            DateTime d8 = DateTime.Parse("04/08/2020");
            Console.WriteLine("DateTime no formato brasileiro: {0}", d8);
            /* ParseExact para personalizar a formatação da data */
            DateTime d9 = DateTime.ParseExact("2020-08-04", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime com ParseExact para personalizar formatação: {0}", d9);
            TimeSpan d10 = TimeSpan.FromTicks(180000000000L);
            Console.WriteLine("TimeSpan de 180.000.000: {0}", d10);
            Console.WriteLine();
            /* Formatação de data */
            Console.WriteLine("Formatação de data: {0}", d3.ToLongDateString());
            /* Formatação de hora */
            Console.WriteLine("Formatação de hora: {0}", d3.ToLongTimeString());
            /* Formatação de data (curto) */
            Console.WriteLine("Formatação curta de data: {0}", d3.ToShortDateString());
            /* Formatação de hora (curto) */
            Console.WriteLine("Formatação curta de hora: {0}", d3.ToShortTimeString());
            /* Formatação personalizada com ToString */
            Console.WriteLine("Formatação personalizada: {0}", d3.ToString("dd/MM/yy HH:mm"));

        }
    }
}
