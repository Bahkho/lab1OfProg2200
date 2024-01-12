namespace challenge2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the pass code?");
        var code = Console.ReadLine();

        if (code == "secret")
        {
            Console.WriteLine("Authenticated...");
            Console.WriteLine("Chamge the pass code?");
            var change = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Not Authenticated...");
        }
    }
}
