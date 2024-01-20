//        Module 3 Exception Handling & Debugging
// 1. Enhance the StudentManager program to have a custom error class called MyCustomException
// that extends FormatException. Make sure the main program code correctly handles the custom
// error class in a try-catch and reports the proper error message. (2 pts) _____
//
// 2. Demonstrate your knowledge of the debugger to your instructor. (See the recording part)
//  a. Comment out any try-catch and force a debug on exception.
//  b. Re-instate the commented-out code and demonstrate the following:
//      i. A breakpoint
//      ii. Step Over
//      iii. Step Into
namespace challenge6;

class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>();

        var adding = true;

        while (adding)
        {
            try
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");

                newStudent.Grade = Util.Console.AskInt("Student Grade: ");

                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");

                newStudent.Address = Util.Console.Ask("Student Address: ");

                newStudent.Phone = Util.Console.AskInt("Student Phone Number: ");

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            catch (FormatException msg)
            {
                Console.WriteLine(msg.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error adding student, Please try again");
            }
        }

        foreach (var student in students)
        {
            Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
        }
    }

    static void Import()
    {
        var importedStudent = new Student("Jenny", 86, "birthday", "address", 123456);
        Console.WriteLine(importedStudent.Name);
    }
}

class Member
{
    public string Name;
    public string Address;
    protected int phone;

    public int Phone
    {
        set { phone = value; }
    }
}

class Student : Member
{
    static public int Count = 0;

    public int Grade;
    public string Birthday;

    public Student()
    {

    }

    public Student(string name, int grade, string birthday, string address, int phone)
    {
        Name = name;
        Grade = grade;
        Birthday = birthday;
        Address = address;
        Phone = phone;
    }
}

class Teacher : Member
{
    public string Subject;
}