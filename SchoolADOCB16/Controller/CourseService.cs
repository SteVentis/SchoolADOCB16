using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.Controller
{
    public class CourseService : IService
    {
       public void Creating()
       {
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {

                    CourseRepository course = new CourseRepository();
                    course.Create();

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
        public void Reading()
        {
            MessageToUserInput message = new MessageToUserInput();
            PrintCourse printCourse = new PrintCourse();
            CourseRepository course = new CourseRepository();
            try
            {
                
                int id = message.WriteID();
                var courseRead = course.Read(id);
                printCourse.Print(courseRead);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ReadingList()
        {
            CourseRepository course = new CourseRepository();
            PrintCourse printCourse = new PrintCourse();
            try
            {
                var courselist = course.GetListOf();
                printCourse.PrintList(courselist);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void Editing()
        {
            CourseRepository course = new CourseRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    course.Update(id);
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
        public void Deleting()
        {
            CourseRepository course = new CourseRepository();
            MessageToUserInput message = new MessageToUserInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int id = message.WriteID();
                    course.Delete(id);
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
    }
}
