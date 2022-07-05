using SchoolADOCB16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    public class PrintCourse : IPrint<Course>
    {
        public void Print(Course course)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Course ID: {course.ID}");
            Console.WriteLine($"Course Title: {course.Title}");
            Console.WriteLine($"Course Stream: {course.Stream}");
            Console.WriteLine($"Course Type: {course.Type}");
            Console.WriteLine($"Course Starting Date: {course.StartDate}");
            Console.WriteLine($"Course Ending Date: {course.EndDate}");
            Console.ResetColor();
            
        }
        public void PrintList(List<Course> courses)
        {
            foreach (var course in courses)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Course ID: {course.ID}");
                Console.WriteLine($"Course Title: {course.Title}");
                Console.WriteLine($"Course Stream: {course.Stream}");
                Console.WriteLine($"Course Type: {course.Type}");
                Console.WriteLine($"Course Starting Date: {course.StartDate}");
                Console.WriteLine($"Course Ending Date: {course.EndDate}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("_____________________________________________");
                Console.ResetColor();

            }
        }
    }
}
