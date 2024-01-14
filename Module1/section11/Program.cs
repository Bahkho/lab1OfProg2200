namespace section11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name:");
        var name = TryAgain();

        Console.WriteLine("Please enter your age:");
        var age = TryAgain();

        Console.WriteLine("Please enter your month of birth:");
        var month = TryAgain();

        Console.WriteLine("Your name is {0}", name);
        Console.WriteLine("Your age is {0}", age);
        Console.WriteLine("Your month of birth is {0}", month);

        if (month == "march")
        {
            Console.WriteLine("You are an Aries.");
        }
        else if (month == "april")
        {
            Console.WriteLine("You are a Taurus.");
        }
        else if (month == "may")
        {
            Console.WriteLine("You are a Gemini.");
        }

    }

    static string TryAgain()
    {
        var answer = Console.ReadLine();
        if (answer == "")
        {
            Console.WriteLine("You didn't type anything, please try again:");
            return Console.ReadLine();
        }
        return answer;
    }
}

