using SchoolADOCB16.Controller;
using SchoolADOCB16.Enums;
using SchoolADOCB16.RepositoryServices;
using SchoolADOCB16.Views.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.ConsoleHelpers
{
    public class ConsoleController
    { 
        public static void Start()
        {
            CourseService courseService = new CourseService();
            TrainerService trainerService = new TrainerService();
            StudentService studentService = new StudentService();
            AssignmentService assignmentService = new AssignmentService();
            TrainersPerCourseService trainersPerCourse = new TrainersPerCourseService();
            StudentsPerCourseService studentsPerCourse = new StudentsPerCourseService();
            MessageToUserInput message = new MessageToUserInput();
            while (true)
            {
                int choise = ConsoleView.View();
                UserChoise userChoise = (UserChoise)choise;
                Console.Clear();
                switch (userChoise)
                {
                    case UserChoise.CreateCourse: courseService.Creating(); break;
                    case UserChoise.ReadCourse: courseService.Reading(); break;
                    case UserChoise.EditCourse: courseService.Editing(); break;
                    case UserChoise.DeleteCourse: courseService.Deleting(); break;
                    case UserChoise.ReadListOfCourses: courseService.ReadingList(); break;
                    case UserChoise.CreateTrainer: trainerService.Creating(); break;
                    case UserChoise.ReadTrainer: trainerService.Reading(); break;
                    case UserChoise.EditTrainer: trainerService.Editing(); break;
                    case UserChoise.DeleteTrainer: trainerService.Deleting(); break;
                    case UserChoise.ReadListOfTrainers: trainerService.ReadingList(); break;
                    case UserChoise.CreateStudent: studentService.Creating(); break;
                    case UserChoise.ReadStudent: studentService.Reading(); break;
                    case UserChoise.EditStudent: studentService.Editing(); break;
                    case UserChoise.DeleteStudent: studentService.Deleting(); break;
                    case UserChoise.ReadListOfStudents: studentService.ReadingList(); break;
                    case UserChoise.ReadListOfStudentsInMoreCourses: studentService.HardcoreStudentsReading(); break;
                    case UserChoise.CreateAssignment: assignmentService.Creating(); break;
                    case UserChoise.ReadAssignment: assignmentService.Reading(); break;
                    case UserChoise.EditAssignment: assignmentService.Editing(); break;
                    case UserChoise.DeleteAssignment: assignmentService.Deleting(); break;
                    case UserChoise.ReadListOfAssignments: assignmentService.ReadingList(); break;
                    case UserChoise.AddTrainerToCourse: trainersPerCourse.PerCourseAddingService(); break;
                    case UserChoise.ReadListTrainersPerCourse: trainersPerCourse.PerCourseReadingService(); break;
                    case UserChoise.EditTrainerPerCourse: trainersPerCourse.PerCourseEditingService(); break;
                    case UserChoise.DeleteTrainersPerCourse: trainersPerCourse.PerCourseDeletingService(); break;
                    case UserChoise.AddStudentToCourse: studentsPerCourse.PerCourseAddingService(); break;
                    case UserChoise.ReadListStudentsPerCourse: studentsPerCourse.PerCourseReadingService(); break;
                    case UserChoise.EditStudentPerCourse: studentsPerCourse.PerCourseEditingService(); break;
                    case UserChoise.DeleteStudentPerCourse: studentsPerCourse.PerCourseDeletingService(); break;
                    case UserChoise.ReadListAssignmentPerCourse: assignmentService.ReadingAssignmentPerCourse(); break;
                    case UserChoise.ReadListAssignmentsPerStudentPerCourse: assignmentService.ReadingAssignmentPerStudentPerCourse(); break;
                    default: message.ErrorMessage(); break;
                }
               
            }
          

        }
    }
}
