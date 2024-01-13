namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 5; x++)
            {
                PrintNumbers(1, 10, true);
                PrintNumbers(10, 1, false);
            }
        }

        static void PrintNumbers(int start, int end, bool ascending)
        {
            int increment = ascending ? 1 : -1;

            for (int i = start; ascending ? i <= end : i >= end; i += increment)
            {
                Console.WriteLine(i);
            }
        }
    }
}