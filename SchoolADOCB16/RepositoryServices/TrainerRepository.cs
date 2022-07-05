using SchoolADOCB16.Data;
using SchoolADOCB16.Entities;
using SchoolADOCB16.Views;
using SchoolADOCB16.Views.Print;
using SchoolADOCB16.Views.Print.Messages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.RepositoryServices
{
    public class TrainerRepository : IRepository<Trainer>
    {
        public void Create()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                TrainerInput input = new TrainerInput();
                string firstName = input.FirstName();
                string lastName = input.LastName();
                string subject = input.Subject();
                string command = $"INSERT INTO Trainer(FirstName,LastName,Subject) VALUES('{firstName}','{lastName}','{subject}')";
                SqlCommand cmd = new SqlCommand(command, connection);
                int rows = cmd.ExecuteNonQuery();
                message.CreateMessage(rows);
            }
        }
        public Trainer Read(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Trainer WHERE ID = '{id}'";
                SqlCommand cmd = new SqlCommand(command,connection);
                Trainer trainer = new Trainer();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    trainer.ID = reader.GetInt32(0);
                    trainer.FirstName = reader.GetString(1);
                    trainer.LastName = reader.GetString(2);
                    trainer.Subject = reader.GetString(3);
                }
                reader.Close();
                return trainer;
            }
        }
        public List<Trainer> GetListOf()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                string command = $"SELECT * FROM Trainer";
                SqlCommand cmd = new SqlCommand(command,connection);
                List<Trainer> trainers = new List<Trainer>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Trainer trainer = new Trainer()
                    {
                        ID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Subject = reader.GetString(3)
                    };
                    trainers.Add(trainer);
                }
                reader.Close();
                return trainers;
            }
        }
        public void Update(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                TrainerInput input = new TrainerInput();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string firstName = input.FirstName();
                string lastName = input.LastName();
                string subject = input.Subject();
                string command = $"UPDATE Trainer " +
                                 $"SET FirstName = '{firstName}'," +
                                     $"LastName = '{lastName}'," +
                                     $"Subject = '{subject}'" +
                                 $"WHERE ID = {id}";
                SqlCommand cmd = new SqlCommand(command,connection);
                int rows = cmd.ExecuteNonQuery();
                message.UpdateMessage(rows);
            }

        }
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionHelper.CnnVall("Connect")))
            {
                connection.Open();
                MessageToUserFromMethods message = new MessageToUserFromMethods();
                string command1 = $"DELETE FROM TrainersPerCourse WHERE Trainer_ID = '{id}'";
                string command2 = $"DELETE FROM Trainer WHERE ID = '{id}'";
                SqlCommand sql = new SqlCommand(command1,connection);
                sql.ExecuteNonQuery();
                sql = new SqlCommand(command2,connection);
                int rows = sql.ExecuteNonQuery();
                message.DeleteMessage(rows);
            }

        }

    }
}
