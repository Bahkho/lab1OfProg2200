using System;

namespace challenge9
{
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

    interface IGraduate
    {
        void Graduate();
    }

    class Student : Member, IGraduate
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;
        public School School;

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

        public void Graduate()
        {
            Console.WriteLine($"{Name} is graduating!");
        }
    }
}
