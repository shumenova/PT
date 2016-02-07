using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._8
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public string Male;
        public int Age;
        private double GPA;

        public Student(string FirstName, string LastName, string Male, int Age, double GPA)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Male = Male;
            this.Age = Age;
            this.GPA = GPA;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Male + " " + this.Age + " " + this.GPA;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            string Male = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            double GPA = double.Parse(Console.ReadLine());
            Student informa = new Student(FirstName, LastName, Male, Age, GPA);
            Console.WriteLine(informa);
            Console.ReadKey();

        }

    }
}
