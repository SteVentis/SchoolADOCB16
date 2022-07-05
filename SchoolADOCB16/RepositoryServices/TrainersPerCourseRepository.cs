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
    public class TrainersPerCourseRepository : IPerCourseRepository<TrainersPerCourse>
    {
        public List<TrainersPerCourse> DataPerCourseReadList()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = "SELECT Course.ID,Course.Title,Trainer.FirstName,Trainer.LastName " +
                                 "FROM Course INNER JOIN TrainersPerCourse ON Course.ID = TrainersPerCourse.Course_ID INNER JOIN Trainer ON TrainersPerCourse.Trainer_ID = Trainer.ID ORDER BY Course_ID";


                SqlCommand cmd = new SqlCommand(command,connection);
                List<TrainersPerCourse> trainers = new List<TrainersPerCourse>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TrainersPerCourse perCourse = new TrainersPerCourse()
                    {
                        Course_ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        FirstName = reader.GetString(2),
                        LastName = reader.GetString(3)
                    };

                    trainers.Add(perCourse);
                }
                reader.Close();
                return trainers;
            }
        }
        public void AddToCourse(int trainerId,int courseId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"INSERT INTO TrainersPerCourse(Trainer_ID,Course_ID) VALUES('{trainerId}','{courseId}')";
                SqlCommand cmd = new SqlCommand(command, connection);
                int rows = cmd.ExecuteNonQuery();
                message.AddMessage(rows);
            }
        }
        public void UpdateDataPerCourse(int trainerId,int courseId, int newTrainerId, int newCourseId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"UPDATE TrainersPerCourse " +
                                 $"SET Trainer_ID = '{newTrainerId}',Course_ID = '{newCourseId}' " +
                                 $"WHERE Trainer_ID = '{trainerId}' AND Course_ID = '{courseId}'";
                SqlCommand cmd = new SqlCommand(command,connection);
                int rows = cmd.ExecuteNonQuery();
                message.UpdateMessage(rows);
            }
        }
        public void DeleteDataFromCourse(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command = $"DELETE FROM TrainersPerCourse WHERE Trainer_ID = '{id}'";
                SqlCommand cmd = new SqlCommand(command,connection);
                int rows = cmd.ExecuteNonQuery();
                message.DeleteMessage(rows);
            }
        }
    }
}
