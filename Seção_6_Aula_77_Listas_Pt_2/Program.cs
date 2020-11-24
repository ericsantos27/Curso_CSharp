using System;
using System.Collections.Generic;

namespace Seção_6_Aula_77_Listas_Pt_2
{
    class Program
    {
        static void Main(string[] args)
            /* Criação e instanciação da lista*/ 
        {
            List<string> myList1 = new List<string>();

            /* Adicionando dados à lista utilizando "Add" (joga o elemento para o final da lista) */
            myList1.Add("Rosana Paiva");
            myList1.Add("Maria Martins");
            myList1.Add("Desirée Pierri");
            myList1.Add("Aristela Brito");
            /* Adicionando dados à lista utilizando "Insert" indicando a posição que quer inserir */
            myList1.Insert(2, "Luziene Rodrigues");
            myList1.Insert(0, "Viviane Gola");
            myList1.Insert(3, "Kellen Neves");
            myList1.Insert(1, "Aline Karwaka");

            foreach (string element in myList1)
            {
                Console.WriteLine(element);
            }
            /* Comando "Count" para mostrar o tamanho da lista */
            Console.WriteLine();
            Console.WriteLine("Número de elementos da lista: {0}", myList1.Count);

            /* 
             Buscando elementos na lista que contenha um caracter específico. Neste caso, um elemento da lista que começe com 
             a letra 'A'. Utilizar a função'Find' e uma expressão Lambda e atribuir o resultado a uma variável
            */
            Console.WriteLine();
            string element_1 = myList1.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro nome da lista com A = {0}", element_1);

            /* Buscando o último elemento da lista que comece com 'A'. Utilizar a função 'FindLast' */
            Console.WriteLine();
            string element_2 = myList1.FindLast(x => x[0] == 'A');
            Console.WriteLine("ùltimo nome da lista com A = {0}", element_2);

            /* Comando para identificar a posição do primeiro elemento na lista que comece com 'A' */
            Console.WriteLine();
            int pos_1 = myList1.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do primeiro elemento da lista iniciando com a letra A: {0}", pos_1);

            /* Comando para identificar a posição do último elemento da lista que comece com 'A' */
            Console.WriteLine();
            int pos_2 = myList1.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do último elemento da lista iniciando com a letra A: {0}", pos_2);

            /* Comando para filtrar elementos da lista que correspondam a um determinado padrão ou regra. Neste caso, nomes que
            tenham 12 caracteres. Utilizar a função 'FindAll". Para isto será necessário atribuir o resultado a uma nova lista
            */
            Console.WriteLine();
            Console.WriteLine("Elementos da lista com 12 caracteres: ");
            List<string> myList2 = myList1.FindAll(x => x.Length == 12);
            foreach(string element in myList2)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            Console.WriteLine("Removendo elemento da lista: Maria Martins");
            myList1.Remove("Maria Martins");
            foreach(string element in myList1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("Removendo elementos da lista cujo 11º caracter é 'A'");
            myList1.RemoveAll(x => x[11] == 'a');
            foreach(string element in myList1)
            {
                Console.WriteLine(element);
            }

            /* Utilizando o comando 'RemoveAt' para remover elementos pela posição. */
            Console.WriteLine();
            Console.WriteLine("Removendo o elemento da posição 2 da lista: ");
            myList1.RemoveAt(2);
            foreach(string element in myList1)
            {
                Console.WriteLine(element);
            }

            /* Utilizando a função "RemoveRange" para remover um intervalo de elementos. Indicar a partir de qual posição quer
            remover e contar o número de elementos que se quer remover 
            */
            Console.WriteLine();
            Console.WriteLine("Removendo dois elementos da lista a partir da posição 1");
            myList1.RemoveRange(1, 2);
            foreach(string element in myList1)
            {
                Console.WriteLine(element);
            }

        }
    }
}
