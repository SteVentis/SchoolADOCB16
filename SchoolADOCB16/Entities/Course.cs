using SchoolADOCB16.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public CourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation Properties
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        //Constructors
        public Course()
        {

        }
        public Course(string title, string stream, CourseType type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
