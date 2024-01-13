namespace section9;
class Program
{
    static void Main(string[] args)
    {
        // For loop
        for (var i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // While loop
        var code = "";
        while (code != "secret")
        {
            Console.WriteLine("What is the pass code?");
            code = Console.ReadLine();

            if (code != "secret")
            {
                Console.WriteLine("Not Authenticated...");

            }
        }
        Console.WriteLine("Authenticated...");



    }
}