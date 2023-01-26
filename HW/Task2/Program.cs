namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        var Families = new List<string> { "Иванов", "Богданов", "Сидоров", "Пахомов", "Смычкова" };
        DataReader dr = new DataReader();
        DataReader.SortList += Sort;
        dr.data = Families;
        try
        {
            dr.Read();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }

    class DataReader
    {

        public static event Action<List<string>, int> SortList;
        public List<string> data { get; set; }
        public void Read()
        {
            Console.WriteLine("Введите 1 или 2");

            int num = Int32.Parse(Console.ReadLine());

            if (num != 1 && num != 2) throw new FormatException();

            SortList.Invoke(data, num);

        }


    }

    public static void Sort(List<string> list, int num)
    {
        switch (num)
        {
            case 1:
                {
                    list.Sort();
                    foreach (string i in list)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                }
            case 2:
                {
                    list.Sort();
                    list.Reverse();
                    foreach (string i in list)
                    {
                        Console.WriteLine(i);

                    }
                    break;
                }
        }
    }
}


