using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolADOCB16.Entities;
using System.Data.SqlClient;
using SchoolADOCB16.Data;
using SchoolADOCB16.Views;
using SchoolADOCB16.Views.Print.Messages;

namespace SchoolADOCB16.RepositoryServices
{
    public class AssignmentRepository
    {
        public void Create()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                AssignmentInput input = new AssignmentInput();
                string title = input.Title();
                string description = input.Description();
                DateTime subDate = input.SubmissionDate();
                int oralMark = input.OralMark();
                int totalMark = input.TotalMark();
                int courseId = input.CourseID();
                string command = $"INSERT INTO Assignment(Title,Description,SubmissionDate,OralMark,TotalMark,CourseID) " +
                                 $"VALUES('{title}','{description}','{subDate}','{oralMark}','{totalMark}','{courseId}')";
                SqlCommand sql = new SqlCommand(command, connection);

                int rows = sql.ExecuteNonQuery();
                message.CreateMessage(rows);
            }
        }
        public Assignment Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Assignment WHERE ID = {id}";
                SqlCommand sql = new SqlCommand(command,connection);
                Assignment assignment = new Assignment();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    assignment.ID = reader.GetInt32(0);
                    assignment.Title = reader.GetString(1);
                    assignment.Description = reader.GetString(2);
                    assignment.SubmissionDate = reader.GetDateTime(3);
                    assignment.OralMark = reader.GetInt32(4);
                    assignment.TotalMark = reader.GetInt32(5);
                    assignment.CourseID = reader.GetInt32(6);
                }
                reader.Close();
                return assignment;
            }
        }
        public List<Assignment> GetListOf()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Assignment";
                SqlCommand sql = new SqlCommand(command,connection);
                List<Assignment> assignments = new List<Assignment>();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Assignment assignment = new Assignment()
                    {
                        ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                        SubmissionDate = reader.GetDateTime(3),
                        OralMark = reader.GetInt32(4),
                        TotalMark = reader.GetInt32(5),
                        CourseID = reader.GetInt32(6)
                    };
                    assignments.Add(assignment);
                }
                reader.Close();
                return assignments;
            }
        }
        public void Update(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                AssignmentInput input = new AssignmentInput();
                string title = input.Title();
                string description = input.Description();
                DateTime subDate = input.SubmissionDate();
                int oralMark = input.OralMark();
                int totalMark = input.TotalMark();
                int courseId = input.CourseID();
                string command = $"UPDATE Assignment " +
                                 $"SET Title = '{title}'," +
                                     $"Description = '{description}'," +
                                     $"SubmissionDate = '{subDate}'," +
                                     $"OralMark = '{oralMark}'," +
                                     $"TotalMark = '{totalMark}'," +
                                     $"CourseID = '{courseId}'" +
                                 $"WHERE ID = {id}";
                SqlCommand sql = new SqlCommand(command,connection);
                int rows = sql.ExecuteNonQuery();
                message.UpdateMessage(rows);
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"DELETE FROM Assignment WHERE ID = '{id}'";
                SqlCommand sql = new SqlCommand(command, connection);
                int rows = sql.ExecuteNonQuery();
                message.DeleteMessage(rows);
            }
        }
        public List<Assignment> AssignmentPerCourseRead()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                List<Assignment> assignments = new List<Assignment>();
                string command = "SELECT Assignment.Title,Course.Title " +
                                 "FROM Assignment INNER JOIN Course ON Assignment.CourseID = Course.ID";
                SqlCommand sql = new SqlCommand(command, connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Assignment assignment = new Assignment()
                    {
                        Title = reader.GetString(0),
                        Course = new Course()
                        {
                            Title = reader.GetString(1)
                        }
                    };
                    assignments.Add(assignment);
                }
                reader.Close();
                return assignments;
            }
        }

        public List<Assignment> AssignmentsPerStudentPerCourseRead()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                List<Assignment> assignments = new List<Assignment>();
                string command = "SELECT Assignment.Title,Course.Title,Student.FirstName,Student.LastName " +
                                 "FROM Student INNER JOIN StudentsPerCourse ON Student.ID = StudentsPerCourse.Student_ID " +
                                              "INNER JOIN Course ON StudentsPerCourse.Course_ID = Course.ID " +
                                              "INNER JOIN Assignment ON Course.ID = Assignment.CourseID " +
                                 "ORDER BY Student.FirstName";
                SqlCommand sql = new SqlCommand(command, connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Assignment assignment = new Assignment()
                    {
                        Title = reader.GetString(0),
                        Course = new Course()
                        {
                            Title = reader.GetString(1),
                            
                        }
                    };
                    Student student = new Student()
                    {
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3)
                    };

                    assignment.Course.Students.Add(student);
                    assignments.Add(assignment);
                    
                }
                reader.Close();


                return assignments;
            }
        }
    }
}
