using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    public class MessageToUserInput
    {

        public bool CreateAnotherMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do You Want To Add Another? (y/n)");
            Console.ResetColor();
            string answer = Console.ReadLine();
            bool create = answer == "y" ? true : false;
            return create;
        }
        public int WriteID()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Write ID Of Your Preference : ");
            Console.ResetColor();
            return Convert.ToInt32(Console.ReadLine());
        }
        
        public bool UpdateAnotherMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do You Want To Update Another? (y/n)");
            Console.ResetColor();
            string answer = Console.ReadLine();
            bool create = answer == "y" ? true : false;
            return create;
        }
        
        public bool DeleteAnotherMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do You Want To Delete Another? (y/n)");
            Console.ResetColor();
            string answer = Console.ReadLine();
            bool create = answer == "y" ? true : false;
            return create;
        }
        public void ErrorMessage() 
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wrong Choise....Try Again");
            Console.ResetColor();
        }
    }
}
