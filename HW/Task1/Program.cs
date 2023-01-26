namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Exception[] exceptions =
        {
            new IndexOutOfRangeException("Exception 1"),
            new FieldAccessException("Exception 2"),
            new AccessViolationException("Exception 3"),
            new FileLoadException("Exception 4"),
            new MyException("This is my exception")


        };
        foreach (Exception ex in exceptions)
        {
            try
            {
                throw ex;
            }
            catch (Exception)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.ReadKey();
    }

    class MyException : Exception
    {
        public MyException(string _message) : base(_message) { }
    }
}

