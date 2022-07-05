using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolADOCB16.ConsoleHelpers
{
    
    public class ConsoleView
    {
        public static int View()
        {
            const int first = -5;
            const int second = -15;
            const int third = -25;
            const int fourth = -3;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"",first}------------------------------ Welcome To The Coding BootCamp 16 ----------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{"|",first}{" --- Create --- ",second}{" --- Read --- ",second}{" --- Edit --- ",second}{"  --- Delete --- ",second}{"  --- Read List Of ---"}");
            Console.WriteLine($"{"|",first}{"(1)Course     ",second}{" (2)Course     ",second}{" (3)Course   ",second}{"   (4)Course    ",second}{"      (5)Courses",second}");
            Console.WriteLine($"{"|",first}{"(6)Trainer    ",second}{" (7)Trainer    ",second}{" (8)Trainer   ",second}{"   (9)Trainer    ",second}{"     (10)Trainers",second}");
            Console.WriteLine($"{"|",first}{"(11)Student   ",second}{" (12)Student   ",second}{" (13)Student   ",second}{"   (14)Student    ",second}{"    (15)Students",second}");
            Console.WriteLine($"{"|",first}{"(17)Assignment",second}{" (18)Assignment",second}{" (19)Assignment   ",second}{"(20)Assignment    ",second}{" (21)Assignments",second}");
            Console.WriteLine($"{"|",-130}");
            Console.WriteLine($"{"|",first}{"  --- Add ---",third}{"--- Read List Of ---",third}{"  --- Edit ---",third}{"--- Delete ---",third}");
            Console.WriteLine($"{"|",first}{"(22)TrainerToCourse",third}{"(23)TrainersPercourse ",third}{"(24)Trainer and Course ",third}{"(25)Trainer From Course",third}");
            Console.WriteLine($"{"|",first}{"(26)StudentToCourse",third}{"(27)StudentsPercourse ",third}{"(28)Student and Course ",third}{"(29)Student From Course",third}");
            Console.WriteLine($"{"|",-130}");
            Console.WriteLine($"{"|",first}{"  -------- Other Choises --------"}");
            Console.WriteLine($"{"|",fourth}{"  (16)students that belong to more than one courses"}");
            Console.WriteLine($"{"|",fourth}{"  (30)Read List Of the Assignments Per Course"}");
            Console.WriteLine($"{"|",fourth}{"  (31)Read List Of the Assignments Per Course Per Student"}");
            Console.ResetColor();
            



            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
