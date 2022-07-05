using SchoolADOCB16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    public class PrintAssignment : IPrint<Assignment>
    {
        public void Print(Assignment assignment)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Assignment's ID : {assignment.ID}");
            Console.WriteLine($"Assignment's Title : {assignment.Title}");
            Console.WriteLine($"Assignment's Description : {assignment.Description}");
            Console.WriteLine($"Submission Date : {assignment.SubmissionDate}");
            Console.WriteLine($"Oral Mark : {assignment.OralMark}");
            Console.WriteLine($"Total Mark : {assignment.TotalMark}");
            Console.WriteLine($"Course ID : {assignment.CourseID}");
            Console.ResetColor();
        }
        public void PrintList(List<Assignment> assignments)
        {
            foreach (var assignment in assignments)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Assignment's ID : {assignment.ID}");
                Console.WriteLine($"Assignment's Title : {assignment.Title}");
                Console.WriteLine($"Assignment's Description : {assignment.Description}");
                Console.WriteLine($"Submission Date : {assignment.SubmissionDate}");
                Console.WriteLine($"Oral Mark : {assignment.OralMark}");
                Console.WriteLine($"Total Mark : {assignment.TotalMark}");
                Console.WriteLine($"Course ID : {assignment.CourseID}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("___________________________________________________");
                Console.ResetColor();
            }
        }
        public void PrintListAssignmentPerStudentPerCourse(List<Assignment> assignments)
        {
           
            foreach (var assignment in assignments)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Assignment's Title : {assignment.Title}");
                Console.WriteLine($"Course title : {assignment.Course.Title}");
                Console.ResetColor();
                foreach (var stu in assignment.Course.Students)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Student's First Name : {stu.FirstName}");
                    Console.WriteLine($"Student's Last Name : {stu.LastName}");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("___________________________________________________");
                Console.ResetColor();
            }
        }
        public void PrintListAssignmentPerCourse(List<Assignment> assignments)
        {
            
            foreach (var assignment in assignments)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Assignments title : {assignment.Title}");
                Console.WriteLine($"Course title : {assignment.Course.Title}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("___________________________________________________");
                Console.ResetColor();
            }
        }
    }

}
