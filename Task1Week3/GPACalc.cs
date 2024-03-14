using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Week3
{
    internal class GPACalc
    {
        static void Main(string[] args)
        {
            Course[] courses = new Course[]; // Array to store courses

            Console.WriteLine("Welcome to our GPA calculator");
            //Prompt user to input course detials
            int numCourses = 0; //counter for number of courses
            while (numCourses < 10);
            {
                Console.WriteLine("\n Enter Course deails or type 'done' to finish:");
                Console.Write("CourseName: ");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                    break;

                Console.Write("CourseCode: ");
                string code = Console.ReadLine();

                Console.Write("CourseUnit: ");
                int unit = int.Parse(Console.ReadLine());

                Console.Write("Course Score: ");
                int score = int.Parse(Console.ReadLine());
                // Calculate grade, grade unit, and quality point
                string grade = CalculateGrade(score);
                int gradeUnit = CalculateGradeUnit(grade);
                int qualityPoint = unit * gradeUnit;


                    


            }
            static string CalculateGrade(int score)
            {
                switch (score)
                {
                    case >= 70:
                        return "A";
                    case >= 60:
                        return "B";
                    case >= 50:
                        return "C";
                    case >= 45:
                        return "D";
                    case >= 40:
                        return "E";
                    case <= 39:
                        return "F";
                }
            }
            static int CalculateGradeUnit(string grade)
            {
                switch (grade)
                {
                    case "A": return 5;

                    case "B": return 4;

                    case "C": return 3;

                    case "D": return 2;

                    case "E": return 1;

                    default: return 0;

                }
            }
        }
    }
}
