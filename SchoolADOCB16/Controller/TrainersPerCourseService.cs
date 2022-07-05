using SchoolADOCB16.Entities;
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
    public class TrainersPerCourseService : IPerCourseService
    {
        public void PerCourseAddingService()
        {
            bool run = true;
            TrainersPerCourseRepository trainer = new TrainersPerCourseRepository();
            TrainerInput inputTrainer = new TrainerInput();
            CourseInput inputCourse = new CourseInput();
            while (run)
            {
                try
                {
                    
                    int trainerId =  inputTrainer.TrainerIdQuestion();
                    int courseId = inputCourse.CourseIdQuestion();
                    trainer.AddToCourse(trainerId,courseId);
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
        public void PerCourseReadingService()
        {
            try
            {
                TrainersPerCourseRepository trainer = new TrainersPerCourseRepository();
                PrintPerCourse printPer = new PrintPerCourse();
                var trainersPerCourse = trainer.DataPerCourseReadList();
                printPer.TrainerPerCourse(trainersPerCourse);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void PerCourseEditingService()
        {
            TrainersPerCourseRepository trainer = new TrainersPerCourseRepository();
            TrainerInput inputTrainerId = new TrainerInput();
            CourseInput inputCourseId = new CourseInput();
            bool run = true;
            while (run)
            {
                try
                {
                    int trainerId = inputTrainerId.TrainerIdQuestion();
                    int courseId = inputCourseId.CourseIdQuestion();
                    int newTrainerId = inputTrainerId.NewTrainerIdQuestion();
                    int newCourseId = inputCourseId.NewCourseIdQuestion();
                    trainer.UpdateDataPerCourse(trainerId, courseId, newTrainerId, newCourseId);
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
        public void PerCourseDeletingService()
        {
            bool run = true;
            TrainersPerCourseRepository trainer = new TrainersPerCourseRepository();
            TrainerInput inputTrainerId = new TrainerInput();
            while (run)
            {
                try
                {
                    int trainerId = inputTrainerId.TrainerIdQuestion();
                    trainer.DeleteDataFromCourse(trainerId);
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
    }
}
