using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Entities
{
    public class StudentsPerCourse
    {
        public StudentsPerCourse()
        {

        }

        public StudentsPerCourse(int student_ID, int course_ID)
        {
            Student_ID = student_ID;
            Course_ID = course_ID;
        }

        public int Student_ID { get; set; }
        public int Course_ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
