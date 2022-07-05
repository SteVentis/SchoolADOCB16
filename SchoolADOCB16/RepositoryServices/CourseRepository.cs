using SchoolADOCB16.Data;
using SchoolADOCB16.Entities;
using SchoolADOCB16.Enums;
using SchoolADOCB16.Views;
using SchoolADOCB16.Views.Print;
using SchoolADOCB16.Views.Print.Messages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.RepositoryServices
{
    public class CourseRepository : IRepository<Course>
    {
        public void Create()
        {
            using(SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                CourseInput input = new CourseInput();
                string title = input.Title();
                string stream = input.Stream();
                int type = input.TypeOfCourse();
                DateTime startDate = input.StartingDate();
                DateTime endDate = input.EndingDate();
                string command = $"INSERT INTO Course(Title, Stream, Type, StartDate, EndDate) " +
                                 $"VALUES('{title}','{stream}','{type}','{startDate}','{endDate}')";
                SqlCommand cmdInsert = new SqlCommand(command, connection);
                    
                int insertRow = cmdInsert.ExecuteNonQuery();
                message.CreateMessage(insertRow);
            }
        }
        public Course Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Course WHERE ID = '{id}'";
                SqlCommand readQuery = new SqlCommand(command,connection);
                Course course = new Course();
                SqlDataReader reader = readQuery.ExecuteReader();
                while (reader.Read())
                {
                    
                    course.ID = reader.GetInt32(0);
                    course.Title = reader.GetString(1);
                    course.Stream = reader.GetString(2);
                    course.Type = (CourseType)reader.GetInt32(3);
                    course.StartDate = reader.GetDateTime(4);
                    course.EndDate = reader.GetDateTime(5);
                }
                reader.Close();

                return course;
            }
        }
        public List<Course> GetListOf()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = "SELECT * FROM Course";
                SqlCommand readQuery = new SqlCommand(command,connection);
                List<Course> courses = new List<Course>();
                SqlDataReader sqlDataReader = readQuery.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Course course = new Course()
                    {
                        ID = sqlDataReader.GetInt32(0),
                        Title = sqlDataReader.GetString(1),
                        Stream = sqlDataReader.GetString(2),
                        Type = (CourseType)sqlDataReader.GetInt32(3),
                        StartDate = sqlDataReader.GetDateTime(4),
                        EndDate = sqlDataReader.GetDateTime(5)
                    };
                    

                    courses.Add(course);
                }
                sqlDataReader.Close();

                return courses;
            }
        }
        public void Update(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                CourseInput input = new CourseInput();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string title = input.Title();
                string stream = input.Stream();
                int type = input.TypeOfCourse();
                DateTime startDate = input.StartingDate();
                DateTime endDate = input.EndingDate();
                string command = $"UPDATE Course " +
                                                $"SET Title = '{title}'," +
                                                    $"Stream = '{stream}'," +
                                                    $"Type = '{type}'," +
                                                    $"StartDate = '{startDate}'," +
                                                    $"EndDate = '{endDate}' " +
                                                $"WHERE ID = {id}";
                SqlCommand cmd = new SqlCommand(command,connection);
                int rowsUp = cmd.ExecuteNonQuery();
                message.UpdateMessage(rowsUp);
            }


        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command1 = $"DELETE FROM Assignment WHERE CourseID ='{id}'";
                string command2 = $"DELETE FROM StudentsPerCourse WHERE Course_ID = {id}";
                string command3 = $"DELETE FROM TrainersPerCourse WHERE Course_ID = {id}";
                string command4 = $"DELETE FROM Course WHERE ID = '{id}'";
                SqlCommand sql = new SqlCommand(command1, connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand(command2, connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand(command3, connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand(command4, connection);
                int rows = sql.ExecuteNonQuery();
                message.DeleteMessage(rows);
                
            }
        }
      
    }
}
