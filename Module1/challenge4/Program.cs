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
                string nameInput = Console.ReadLine() ?? string.Empty;

                Console.Write("Student Grade: ");
                newStudent.StudentInfo[1] = Console.ReadLine() ?? string.Empty;

                Console.Write("Student Birthday: ");
                newStudent.Birthday = Console.ReadLine() ?? string.Empty;

                Console.Write("Student Address: ");
                newStudent.Address = Console.ReadLine() ?? string.Empty;

                Console.Write("Student Phone Number: ");
                int.TryParse(Console.ReadLine(), out int phone);
                newStudent.Phone = phone;

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
        public string? Birthday; // Declare Birthday field as nullable
        public string? Address;
        public int Phone;
    }
}
