using SchoolADOCB16.Data;
using SchoolADOCB16.Entities;
using SchoolADOCB16.Views.Print.Messages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.RepositoryServices
{
    public class StudentsPerCourseRepository : IPerCourseRepository<StudentsPerCourse>
    {
        public List<StudentsPerCourse> DataPerCourseReadList()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                List<StudentsPerCourse> students = new List<StudentsPerCourse>();
                string command = "SELECT Course.ID,Course.Title,Student.FirstName,Student.LastName " +
                                 "FROM Course INNER JOIN StudentsPerCourse ON Course.ID = StudentsPerCourse.Course_ID " +
                                             "INNER JOIN Student ON StudentsPerCourse.Student_ID = Student.ID " +
                                             "ORDER BY Course_ID ";
                SqlCommand sql = new SqlCommand(command,connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    StudentsPerCourse studentPer = new StudentsPerCourse()
                    {
                        Course_ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3)

                    };
                    students.Add(studentPer);
                }
                reader.Close();
                return students;
            }
        }
        public void AddToCourse(int Id, int courseId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"INSERT INTO StudentsPerCourse(Student_ID,Course_ID) VALUES('{Id}','{courseId}')";
                SqlCommand sql = new SqlCommand(command,connection);
                int rows = sql.ExecuteNonQuery();
                message.AddMessage(rows);
            }
        }
        public void UpdateDataPerCourse(int studentId,int courseId,int newStudentId,int newCourseId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"UPDATE StudentsPerCourse " +
                                 $"SET Student_ID = '{newStudentId}',Course_ID = '{newCourseId}' " +
                                 $"WHERE Student_ID = '{studentId}' AND Course_ID = '{courseId}'";
                SqlCommand sql = new SqlCommand(command, connection);
                int rows = sql.ExecuteNonQuery();
                message.UpdateMessage(rows);
            }
        }
        public void DeleteDataFromCourse(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"DELETE FROM StudentsPerCourse WHERE Student_ID = '{studentId}'";
                SqlCommand cmd = new SqlCommand(command, connection);
                int rows = cmd.ExecuteNonQuery();
                message.DeleteMessage(rows);
            }
        }
        
    }
}
