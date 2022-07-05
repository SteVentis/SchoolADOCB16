using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Entities
{
    public class TrainersPerCourse
    {
        public int Trainer_ID { get; set; }
        public int Course_ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TrainersPerCourse()
        {

        }
        public TrainersPerCourse(int trainer_ID, int course_ID)
        {
            Trainer_ID = trainer_ID;
            Course_ID = course_ID;
        }

    }
}
