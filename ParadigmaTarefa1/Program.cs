namespace ParadigmaTarefa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayData = { 7, 5, 3, 9, 6, 4, 1 };

            IntList handleList = new IntList();
            handleList.data.AddRange(arrayData);
            handleList.listName = "Lista Original";
            handleList.OrganizeList();
        }
    }
}
