using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Entities
{
    public class Trainer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        //Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();

        //Constructors
        public Trainer()
        {

        }
        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
