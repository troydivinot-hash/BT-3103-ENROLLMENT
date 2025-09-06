using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;


namespace EventDriven.Project.Businesslogic.Repository
{
   
    internal class ClientAccountRepository
    {
        private string connectionString = "Data Source=LAPTOP-M9KS1VVV\\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True;TrustServerCertificate=True";

        public AccountModel GetById(int id)
        {
            var account = new AccountModel();
            var client = new ClientModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("dbo.GetClientAccountDetailsById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@ClientId", SqlDbType.Int) { Value = id });

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            client.Id = reader.GetInt32(reader.GetOrdinal("ClientId"));
                            client.Firstname = reader.GetString(reader.GetOrdinal("Firstname"));
                            client.Lastname = reader.GetString(reader.GetOrdinal("Lastname"));
                            client.MobileNumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                            client.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                            client.Address = reader.GetString(reader.GetOrdinal("Address"));
                            client.Birthdate = reader.GetDateTime(reader.GetOrdinal("Birtdate"));

                            account.Id = reader.GetInt32(reader.GetOrdinal("AccountId"));
                            account.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                            account.ModifiedDate = reader.GetDateTime(reader.GetOrdinal("ModifiedDate"));

                            account.ClientModel = client;
                        }
                    }
                }
            }
            return account;
        }

        public List<AccountModel> GetAll()
        {
            var accounts = new List<AccountModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.GetClientAccountDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var account = new AccountModel();
                            var client = new ClientModel();

                            client.Id = reader.GetInt32(reader.GetOrdinal("ClientId"));
                            client.Firstname = reader.GetString(reader.GetOrdinal("Firstname"));
                            client.Lastname = reader.GetString(reader.GetOrdinal("Lastname"));
                            client.MobileNumber = reader.GetString(reader.GetOrdinal("MobileNumber"));
                            client.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                            client.Address = reader.GetString(reader.GetOrdinal("Address"));
                            client.Birthdate = reader.GetDateTime(reader.GetOrdinal("Birthdate"));

                            account.Id = reader.GetInt32(reader.GetOrdinal("AccountId"));
                            account.Balance = reader.GetDecimal(reader.GetOrdinal("Balance"));
                            account.ModifiedDate = reader.GetDateTime(reader.GetOrdinal("ModifiedDate"));

                            account.ClientModel = client;
                            accounts.Add(account);
                        }
                    }
                }
            }
            return accounts;
        }
        public void CreateClient(AccountModel accountModel)
        {
            string storedProcedure = "dbo.CreateClientAccount";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Firstname", accountModel.ClientModel.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", accountModel.ClientModel.Lastname);
                cmd.Parameters.AddWithValue("@MobileNumber", accountModel.ClientModel.MobileNumber);
                cmd.Parameters.AddWithValue("@Gender", accountModel.ClientModel.Gender);
                cmd.Parameters.AddWithValue("@Address", accountModel.ClientModel.Address);
                cmd.Parameters.AddWithValue("@Birthdate", accountModel.ClientModel.Birthdate);
                cmd.Parameters.AddWithValue("@Balance", accountModel.Balance);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateClient(AccountModel accountModel)
        {
            string storedProcedure = "dbo.UpdateClientAccount";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientId", accountModel.ClientModel.Id);
                cmd.Parameters.AddWithValue("@Firstname", accountModel.ClientModel.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", accountModel.ClientModel.Lastname);
                cmd.Parameters.AddWithValue("@MobileNumber", accountModel.ClientModel.MobileNumber);
                cmd.Parameters.AddWithValue("@Gender", accountModel.ClientModel.Gender);
                cmd.Parameters.AddWithValue("@Address", accountModel.ClientModel.Address);
                cmd.Parameters.AddWithValue("@Birthdate", accountModel.ClientModel.Birthdate);
                cmd.Parameters.AddWithValue("@Balance", accountModel.Balance);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteClient(int clientId)
        {
            string storedProcedure = "dbo.DeleteClientAccount";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(storedProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientId", clientId);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
