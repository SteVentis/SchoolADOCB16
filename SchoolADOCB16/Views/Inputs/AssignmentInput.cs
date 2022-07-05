using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views
{
    public class AssignmentInput : ISchool
    {
        public string Title()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Title : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public string Description()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Description : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public DateTime SubmissionDate()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Submission Date : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToDateTime(Console.ReadLine());
        }
        public int OralMark()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Oral Mark : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        public int TotalMark()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total Mark : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        public int CourseID()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Write Course ID ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
    
}
