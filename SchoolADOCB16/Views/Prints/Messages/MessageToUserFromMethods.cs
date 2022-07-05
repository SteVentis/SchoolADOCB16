using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print.Messages
{
    public class MessageToUserFromMethods
    {
        public void DeleteMessage(int rows) 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (rows > 0)
              Console.WriteLine("Deleted Succesfully!");
            Console.ResetColor();
        } 
        public void UpdateMessage(int rows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (rows > 0)
                Console.WriteLine("Updated Succsfully!");
            Console.ResetColor();
        }
        public void AddMessage(int rows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (rows > 0)
                Console.WriteLine("Added Succesfully!");
            Console.ResetColor();
        }
        public void CreateMessage(int rows)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (rows > 0)
                Console.WriteLine("Created Succesfully!");
            Console.ResetColor();
        }
    }
}
