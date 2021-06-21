using System;
using System.Collections.Generic;
using System.Linq;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int studentIdAssign = 1;
        public string Name { get; set; }

        private readonly int studentId;
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int stuId, int numberOfCredits, double gpa)
        {
            Name = name;
            studentId = stuId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        
        public static double A = 4.0;
        public static double B = 3.0;
        public static double C = 2.0;
        public static double D = 1.0;

        List<double> classGrades = new List<double>();
        public void AddGrade(int courseCredits, double grade)
        {
            double classGrade = courseCredits * grade;
            classGrades.Add(classGrade);
        }

        private double NewGpa()
        {
            double allGrades = classGrades.Sum();
            double newGpa = allGrades / classGrades.Count;
            return newGpa;
        }
        public string GetGradeLevel()
        {
            string gradeLevel;
            if(NumberOfCredits <= 29)
            {
                gradeLevel = "Freshman";
            }
            else if(NumberOfCredits > 29 || NumberOfCredits < 60)
            {
                gradeLevel = "Sophomore";
            }
            else if(NumberOfCredits > 59 || NumberOfCredits < 90)
            {
                gradeLevel = "Junior";
            }
            else
            {
                gradeLevel = "Senior";
            }
            return gradeLevel;
        }
            


    }
    
}
