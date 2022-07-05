using System.Collections.Generic;
using System;
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
    public class StudentRepository
    {
        public void Create()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                StudentInput input = new StudentInput();
                string firstName = input.FirstName();
                string lastName = input.LastName();
                DateTime dateOfBirth = input.DateOfBirth();
                decimal tuitionFees = input.TuitionFees();
                string command = $"INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) " +
                                                $"VALUES('{firstName}','{lastName}','{dateOfBirth}','{tuitionFees}')";
                SqlCommand sql = new SqlCommand(command, connection);
                int rows = sql.ExecuteNonQuery();
                message.CreateMessage(rows);
            }
        }
        public Student Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Student WHERE ID = '{id}'";
                SqlCommand sql = new SqlCommand(command,connection);
                Student student = new Student();

                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    student.ID = reader.GetInt32(0);
                    student.FirstName = reader.GetString(1);
                    student.LastName = reader.GetString(2);
                    student.DateOfBirth = reader.GetDateTime(3);
                    student.TuitionFees = reader.GetDecimal(4);
                }
                reader.Close();

                return student;
            }
        }
        public List<Student> GetListOf()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                List<Student> students = new List<Student>();
                string command = $"SELECT * FROM Student";
                SqlCommand sql = new SqlCommand(command,connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        DateOfBirth = reader.GetDateTime(3),
                        TuitionFees = reader.GetDecimal(4)
                    };

                    students.Add(student);
                }
                reader.Close();
                return students;
            }
        }
        public void Update(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                StudentInput input = new StudentInput();
                string firstName = input.FirstName();
                string lastName = input.LastName();
                DateTime dateOfBirth = input.DateOfBirth();
                decimal tuitionFees = input.TuitionFees();
                string command = $"UPDATE Student" +
                                                $"SET" +
                                                    $"FirstName = '{firstName}'," +
                                                    $"LastName = '{lastName}'," +
                                                    $"DateOfBirth = '{dateOfBirth}'," +
                                                    $"TuitionFees = '{tuitionFees}'" +
                                                $"WHERE ID = '{id}'";
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
                string command1 = $"DELETE FROM StudentsPerCourse WHERE Student_ID = '{id}'";
                string command2 = $"DELETE FROM Student WHERE ID = '{id}'";
                SqlCommand sql = new SqlCommand(command1, connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand(command2, connection);
                int rows = sql.ExecuteNonQuery();
                message.DeleteMessage(rows);
            }
        }
        public List<Student> HardCoreStudents()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                List<Student> students = new List<Student>();
                string command = "SELECT Student.FirstName,Student.LastName " +
                                 "FROM Student INNER JOIN StudentsPerCourse ON Student.ID = StudentsPerCourse.Student_ID " +
                                 "GROUP BY Student.FirstName,Student.LastName " +
                                 "HAVING COUNT(*) > 1";
                SqlCommand sql = new SqlCommand(command, connection);
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student()
                    {
                        FirstName = reader.GetString(0),
                        LastName = reader.GetString(1)
                    };
                    students.Add(student);
                }
                reader.Close();
                return students;
            }
        }
    }
}
