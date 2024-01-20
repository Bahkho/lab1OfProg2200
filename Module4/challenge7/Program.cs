namespace challenge7
{
    enum Month
    {
        Jan = 0,
        Feb = 1,
        Mar = 2,
        Apr = 3,
        May = 4,
        Jun = 5,
        Jul = 6,
        Aug = 7,
        Sep = 8,
        Oct = 9,
        Nov = 10,
        Dec = 11
    }

    class Data
    {
        public string Name;
        public int Age;
        public Month BirthMonth;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", BirthMonth);

            switch (BirthMonth)
            {
                case Month.Jan:
                    Console.WriteLine("you are a Capricorn.");
                    break;
                case Month.Feb:
                    Console.WriteLine("you are an Aquarius.");
                    break;
                case Month.Mar:
                    Console.WriteLine("you are a Pisces.");
                    break;
                case Month.Apr:
                    Console.WriteLine("you are an Aries.");
                    break;
                case Month.May:
                    Console.WriteLine("you are a Taurus.");
                    break;
                case Month.Jun:
                    Console.WriteLine("you are a Gemini.");
                    break;
                case Month.Jul:
                    Console.WriteLine("you are a Cancer.");
                    break;
                case Month.Aug:
                    Console.WriteLine("you are a Leo.");
                    break;
                case Month.Sep:
                    Console.WriteLine("you are a Virgo.");
                    break;
                case Month.Oct:
                    Console.WriteLine("you are a Libra.");
                    break;
                case Month.Nov:
                    Console.WriteLine("you are a Scorpio.");
                    break;
                case Month.Dec:
                    Console.WriteLine("you are a Sagittarius.");
                    break;
                default:
                    Console.WriteLine("Invalid month.");
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in? (Enter as number: Jan = 0, Feb = 1, etc.)");
            data.BirthMonth = (Month)int.Parse(TryAnswer());

            data.Display();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}