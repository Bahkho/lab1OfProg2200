using System;
using System.Collections.Generic;

namespace challenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                Console.Write("Student Name: ");
                newStudent.StudentInfo[0] = Console.ReadLine();

                Console.Write("Student Grade: ");
                newStudent.StudentInfo[1] = Console.ReadLine();

                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newStudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newStudent);

                Console.Write("Add another? y/n: ");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.StudentInfo[0], student.StudentInfo[1]);
            }
        }
    }

    class Student
    {
        public string[] StudentInfo = new string[2];
        public string Birthday;
        public string Address;
        public int Phone;
    }
}
