namespace section10;

class Program
{
    static void Main(string[] args)
    {
        var studentGrades = new int[10] { 80, 77, 45, 87, 53, 43, 76, 100, 99, 67 };

        foreach (var studentGrade in studentGrades)
        {
            Console.WriteLine(studentGrade);
        }
    }
}
