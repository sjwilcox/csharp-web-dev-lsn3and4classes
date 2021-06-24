using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student me = new Student("Steven", 1, 1, 4.0);
            me.AddGrade(3, Student.A);
            me.AddGrade(12, Student.B);
            me.AddGrade(12, Student.A);
            me.AddGrade(5, Student.B);
            Console.WriteLine(me.GetGradeLevel());
            Console.WriteLine(me.NewGpa());
            Console.WriteLine(me.ToString());
        }
    }
}
