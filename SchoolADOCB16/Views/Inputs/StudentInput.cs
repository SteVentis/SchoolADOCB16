using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views
{
    public class StudentInput : IPerson
    {
        public string FirstName()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("First Name : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public string LastName()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Last Name : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public DateTime DateOfBirth()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Date Of Birth : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToDateTime(Console.ReadLine());
        }
        public decimal TuitionFees()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tuition Fees :");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToDecimal(Console.ReadLine());
        }
        public int StudentIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Write Student's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        public int NewStudentIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Write new Student's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
