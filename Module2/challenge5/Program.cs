using System;

namespace challenge5
{
    class Data
    {
        public string? Name;
        public int Age;
        public string? Month;
        public int Day;

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);
            Console.WriteLine("Your birth day is: {0}", Day);

            // Switch statement to calculate star sign based on month and day
            switch (Month.ToLower())
            {
                case "march":
                    Console.WriteLine("You are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("You are a Taurus.");
                    break;
                case "may":
                    Console.WriteLine("You are a Gemini.");
                    break;
                // Add more cases for other months as needed

                default:
                    Console.WriteLine("Invalid month entered.");
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

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            // Validate and get the day of the month
            Console.WriteLine("What day of the month were you born on?");
            if (int.TryParse(TryAnswer(), out int day))
            {
                data.Day = day;
            }
            else
            {
                Console.WriteLine("Invalid day entered. Please enter a valid number.");
                return;
            }

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
