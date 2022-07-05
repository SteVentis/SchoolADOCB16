using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Controller
{
    public class AssignmentService : IService
    {
        public void Creating()
        {
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {

                    AssignmentRepository assignment = new AssignmentRepository();
                    assignment.Create();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.CreateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }
        public void Deleting()
        {
            AssignmentRepository assignment = new AssignmentRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    assignment.Delete(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.DeleteAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }
        public void Editing()
        {
            AssignmentRepository assignment = new AssignmentRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    assignment.Update(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    bool answer = message.UpdateAnotherMessage();
                    if (answer == false)
                        run = false;
                }
            }
        }
        public void Reading()
        {
            MessageToUserInput message = new MessageToUserInput();
            PrintAssignment printAssignment = new PrintAssignment();
            AssignmentRepository assignment = new AssignmentRepository();
            try
            {

                int id = message.WriteID();
                var trainerRead = assignment.Read(id);
                printAssignment.Print(trainerRead);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ReadingList()
        {
            AssignmentRepository assignment = new AssignmentRepository();
            PrintAssignment printAssignment = new PrintAssignment();
            try
            {
                var trainerList = assignment.GetListOf();
                printAssignment.PrintList(trainerList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ReadingAssignmentPerCourse()
        {
            AssignmentRepository assignment = new AssignmentRepository();
            PrintAssignment printAssignment = new PrintAssignment();

            try
            {
                var assignmentsPerCourse = assignment.AssignmentPerCourseRead();
                printAssignment.PrintListAssignmentPerCourse(assignmentsPerCourse);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadingAssignmentPerStudentPerCourse()
        {
            AssignmentRepository assignment = new AssignmentRepository();
            PrintAssignment printAssignment = new PrintAssignment();

            try
            {
                var assignmentsPerStudentPerCourse = assignment.AssignmentsPerStudentPerCourseRead();
                printAssignment.PrintListAssignmentPerStudentPerCourse(assignmentsPerStudentPerCourse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
