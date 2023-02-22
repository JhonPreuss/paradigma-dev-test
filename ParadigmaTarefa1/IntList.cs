using System;
using System.Collections.Generic;
using System.Linq;

namespace ParadigmaTarefa1
{
    public class IntList
    {
        public string listName { get; set; }

        public List<int> data { get; set; }

        public IntList()
        {
            this.data = new List<int>();
        }

        public void OrganizeList() 
        {
            try
            {
                if (data.Count() == 0)
                    throw new ArgumentNullException("data");

                IntList newIntList = new IntList();
                newIntList.listName = "Lista Manipulada";
                newIntList.data.AddRange(data);
                for (int i = 0; i < newIntList.data.Count; i++)
                {
                    if (newIntList.data[i] == 9)
                        newIntList.data[i] = 5;

                    if (newIntList.data[i] == 4)
                        newIntList.data.RemoveAt(i);
                }

                PrintIntList(data, listName);
                PrintIntList(newIntList.data, newIntList.listName);
                SumListValues(newIntList.data, "Somatório de lista manipulada");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintIntList(List<int> listData, string listName)
        {
            if (!string.IsNullOrEmpty(listName))
                Console.WriteLine(listName); 

            Console.WriteLine(string.Join(",", listData));
        }

        private void SumListValues(List<int> listData, string sumTitle)
        {
            if (listData.Count == 0)
                throw new ArgumentNullException("listData");

            if (!string.IsNullOrEmpty(sumTitle))
                Console.WriteLine(sumTitle);

            Console.WriteLine(listData.Sum());
        }
    }
}
