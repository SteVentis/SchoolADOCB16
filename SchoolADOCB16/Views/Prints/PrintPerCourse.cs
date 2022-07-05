using SchoolADOCB16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    public class PrintPerCourse
    {
        public void TrainerPerCourse(List<TrainersPerCourse> perCourse)
        {
            
            foreach (var per in perCourse)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Course ID : {per.Course_ID}");
                Console.WriteLine($"Course Title : {per.Title}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"First Name : {per.FirstName}");
                Console.WriteLine($"Last Name : {per.LastName}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("__________________________________________");
                Console.ResetColor();

            }
        }
        public void StudentPerCourse(List<StudentsPerCourse> students)
        {

            foreach (var student in students)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Course ID : {student.Course_ID}");
                Console.WriteLine($"Course Title : {student.Title}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"First Name : {student.FirstName}");
                Console.WriteLine($"Last Name : {student.LastName}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("__________________________________________");
                Console.ResetColor();
            }
        }
        
        
    }
}
