using SchoolADOCB16.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views
{
    public class CourseInput : ISchool
    {
        public string Title()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Course Title : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public string Stream()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Course Stream : ");
            Console.WriteLine("____________________");
            Console.ResetColor();

            return Console.ReadLine();
        }
        public int TypeOfCourse()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Course Type : ");
            Console.WriteLine("Press 1 For Part-Time or 2 For FullTime");
            Console.WriteLine("____________________");
            Console.ResetColor();
            int typeNum = Convert.ToInt32(Console.ReadLine());
            if (typeNum == 1)
                return ((int)CourseType.PartTime);
            else
                return ((int)CourseType.FullTime);
        }
        public DateTime StartingDate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Starting Date : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToDateTime(Console.ReadLine());
        }
        public DateTime EndingDate()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ending Date : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToDateTime(Console.ReadLine());
        }
        public int CourseIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Write Course's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        public int NewCourseIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Write new Course's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
