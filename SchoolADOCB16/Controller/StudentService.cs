using SchoolADOCB16.Entities;
using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Controller
{
    public class StudentService : IService
    {
        public void Creating()
        {
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {

                    StudentRepository student = new StudentRepository();
                    student.Create();

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
            StudentRepository student = new StudentRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    student.Delete(id);
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
            StudentRepository student = new StudentRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    student.Update(id);
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
            PrintStudent printStudent = new PrintStudent();
            StudentRepository student = new StudentRepository();
            try
            {

                int id = message.WriteID();
                var trainerRead = student.Read(id);
                printStudent.Print(trainerRead);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ReadingList()
        {
            StudentRepository student = new StudentRepository();
            PrintStudent printStudent = new PrintStudent();
            try
            {
                var trainerList = student.GetListOf();
                printStudent.PrintList(trainerList);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void HardcoreStudentsReading()
        {
            StudentRepository student = new StudentRepository();
            PrintStudent print = new PrintStudent();
            try
            {
                var students = student.HardCoreStudents();
                print.HardcoreStudentPrint(students);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
