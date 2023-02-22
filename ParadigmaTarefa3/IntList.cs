using System;
using System.Collections.Generic;
using System.Linq;

namespace ParadigmaTarefa3
{
    internal class IntList
    {
        public int? firstElementIndex { get; set; }
        public int? secondElementIndex { get; set; }

        public void OrganizeList(List<int> data, int sumValue)
        {
            try
            {
                if (data.Count() == 0)
                    throw new ArgumentNullException("data");
                int? x;
                foreach (var item in data)
                {
                    var index = data.IndexOf(item);
                    this.firstElementIndex = index;

                    x = GetIndexSumList(data, index, sumValue);
                    if (x != null)
                        this.secondElementIndex = x.Value;
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //retorna o index do primeiro elemento cuja a soma seja igual a soma informada
        private int? GetIndexSumList(List<int> listData, int index, int sumValue)
        {
            for(int i = 0; i < listData.Count(); i++)
            {
                if (index != i && listData[index] + listData[i] == sumValue)
                    return i;
            }

            return null;
        }

    }
}
