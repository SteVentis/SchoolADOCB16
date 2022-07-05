using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views
{
    public class TrainerInput : IPerson
    {
        public string FirstName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("First Name : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public string LastName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Last Name : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public string Subject()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Subject : ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Console.ReadLine();
        }
        public int TrainerIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Write Trainer's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        public int NewTrainerIdQuestion()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Write new Trainer's ID: ");
            Console.WriteLine("____________________");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
