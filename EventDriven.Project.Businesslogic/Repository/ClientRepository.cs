using EventDriven.Project.Model;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ClientRepository
    {

        // Define connection string
        private string connectionString  = "Data Source=LAPTOP-M9KS1VVV\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True;TrustServerCertificate=True";

        public int Insert(ClientModel clientModel)
        {
            var query = "INSERT INTO Students (Firstname,Lastname,MobileNumber,Gender,Address,Birthdate)" +
                            "VALUES (@Firstname,@Lastname,@MobileNumber,@Gender,@Address,@Birthdate)";
            var rowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Firstname", clientModel.Firstname);
                        command.Parameters.AddWithValue("@Lastname", clientModel.Lastname);
                        command.Parameters.AddWithValue("@MobileNumber", clientModel.MobileNumber);
                        command.Parameters.AddWithValue("@Gender", clientModel.Gender);
                        command.Parameters.AddWithValue("@Address", clientModel.Address);
                        command.Parameters.AddWithValue("@Birthdate", clientModel.Birthdate);

                        return command.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
        }

        public List<ClientModel> GetAll()
        {
            var query = "SELECT Id, Firstname,Lastname,MobileNumber,Gender,Address,Birtdate FROM Client";

            var list = new List<ClientModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    var client = new ClientModel
                                    {
                                        Id=reader.GetInt32(0),
                                       Firstname= reader.GetString(1),
                                        Lastname = reader.GetString(2),
                                        MobileNumber = reader.GetString(3),
                                        Gender = reader.GetString(4),
                                        Address = reader.GetString(5),
                                        Birthdate = reader.GetDateTime(6)
                                    };

                                   list.Add(client);
                                }
                            }
                            else
                            {
                                throw new Exception("No rows found.");
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return list;
        }

        public ClientModel GetById(int id)
        {
            var query = "SELECT Id, Firstname,Lastname,MobileNumber,Gender,Address,Birthdate FROM Client WHERE id=@id";
            var result = new ClientModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = new ClientModel
                                {
                                    Id = reader.GetInt32(0),
                                    Firstname = reader.GetString(1),
                                    Lastname = reader.GetString(2),
                                    MobileNumber = reader.GetString(3),
                                    Gender = reader.GetString(4),
                                    Address = reader.GetString(5),
                                    Birthdate = reader.GetDateTime(3)
                                };
                            }
                            else
                            {
                                throw new Exception("No client found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return result;
        }

        public int GetCount() {
            var count = 0;
            var query = "SELECT COUNT(*) FROM Client";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
;                    using (SqlCommand command = new SqlCommand(query,connection))
                    {
                        var result = command.ExecuteScalar();
                        count = result != null ? Convert.ToInt32(result) : 0;
                        
                        Console.WriteLine($"Total number of Client: {count}");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return count;
        }
    }
}
