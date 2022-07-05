using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Entities
{
    public class Assignment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Foreign Key
        public int CourseID { get; set; }

        //Navigation Properties
        public Course Course { get; set; } = new Course();

        //Constructors
        public Assignment()
        {

        }
        public Assignment(string title, string description, DateTime submissionDate, int oralMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubmissionDate = submissionDate;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
    }
}
