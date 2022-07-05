using SchoolADOCB16.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Views.Print
{
    public class PrintTrainer : IPrint<Trainer>
    {
        public void Print(Trainer trainer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Trainer's ID : {trainer.ID}");
            Console.WriteLine($"Trainer 's First Name : {trainer.FirstName}");
            Console.WriteLine($"Trainer's Last Name : {trainer.LastName}");
            Console.WriteLine($"Subject : {trainer.Subject}");
            Console.ResetColor();
        }
        public void PrintList(List<Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Trainer's ID : {trainer.ID}");
                Console.WriteLine($"Trainer 's First Name : {trainer.FirstName}");
                Console.WriteLine($"Trainer's Last Name : {trainer.LastName}");
                Console.WriteLine($"Subject : {trainer.Subject}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("_______________________________________________________");
                Console.ResetColor();
            }
        }
     }
}
