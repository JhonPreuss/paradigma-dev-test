using System;
using System.Collections.Generic;

namespace ParadigmaTarefa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 9;

            Console.WriteLine("Soma de entrada {0}",soma);
            List<int> arrayData = new List<int>{2, 7, 11, 15};
            IntList listDataToHandle = new IntList();
            listDataToHandle.OrganizeList(arrayData, soma);

            if (listDataToHandle.firstElementIndex == null || listDataToHandle.secondElementIndex == null)
                throw new Exception("Não foram encontrados índices de elementos que correspondem a soma de informada");

            Console.WriteLine("{0} + {1} são os index dos números encontrados no array de entrada", listDataToHandle.firstElementIndex, listDataToHandle.secondElementIndex);
        }
    }
}
