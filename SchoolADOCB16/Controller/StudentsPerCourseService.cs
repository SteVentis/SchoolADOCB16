using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Controller
{
    public class StudentsPerCourseService : IPerCourseService
    {
        public void PerCourseAddingService()
        {
            bool run = true;
            StudentsPerCourseRepository student = new StudentsPerCourseRepository();
            StudentInput inputStudent = new StudentInput();
            CourseInput inputCourse = new CourseInput();
            while (run)
            {
                try
                {

                    int studentId = inputStudent.StudentIdQuestion();
                    int courseId = inputCourse.CourseIdQuestion();
                    student.AddToCourse(studentId, courseId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageToUserInput message = new MessageToUserInput();
                    bool answer = message.CreateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void PerCourseDeletingService()
        {
            bool run = true;
            StudentsPerCourseRepository student = new StudentsPerCourseRepository();
            StudentInput inputStudentId = new StudentInput();
            while (run)
            {
                try
                {
                    int trainerId = inputStudentId.StudentIdQuestion();
                    student.DeleteDataFromCourse(trainerId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageToUserInput message = new MessageToUserInput();
                    bool answer = message.DeleteAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void PerCourseEditingService()
        {
            StudentsPerCourseRepository Student = new StudentsPerCourseRepository();
            StudentInput inputTrainerId = new StudentInput();
            CourseInput inputCourseId = new CourseInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int studentId = inputTrainerId.StudentIdQuestion();
                    int courseId = inputCourseId.CourseIdQuestion();
                    int newStudentId = inputTrainerId.NewStudentIdQuestion();
                    int newCourseId = inputCourseId.NewCourseIdQuestion();
                    Student.UpdateDataPerCourse(studentId, courseId, newStudentId, newCourseId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    MessageToUserInput message = new MessageToUserInput();
                    bool answer = message.UpdateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }

        public void PerCourseReadingService()
        {
            try
            {
                StudentsPerCourseRepository student = new StudentsPerCourseRepository();
                PrintPerCourse printPer = new PrintPerCourse();
                var studentsPerCourse = student.DataPerCourseReadList();
                printPer.StudentPerCourse(studentsPerCourse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
