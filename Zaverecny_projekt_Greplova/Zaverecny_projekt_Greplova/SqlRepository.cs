using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaverecny_projekt_Greplova
{
    internal class SqlRepository
    {
        public SqlRepository()
        {
            this.connectionstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='C:\USERS\ANNA GREPLOVÁ\SOURCE\REPOS\ZAVERECNYPROJEKTIT4_2023\DB_ZAVERECNY_PROJEKT.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public string connectionstring { get; set; }
        public User GetUser(string username)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Users where Name=@username";
                    command.Parameters.AddWithValue("username", username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Name"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"]);
                        }
                        else
                        {
                            MessageBox.Show("Uživatel s takovýmto uživatelským jménem neexistuje!");
                        }
                    }
                }
                connection.Close();
            }
            return user;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Users";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(reader["Name"].ToString(), Convert.ToInt32(reader["IdEmployee"])));
                        }
                    }
                }
                connection.Close();
            }
            return users;
        }

        public Employee GetEmployee(int idEmployee)
        {
            Employee employee = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Employee where IdEmployee=@idEmployee";
                    command.Parameters.AddWithValue("idEmployee", idEmployee);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee(reader["FirstName"].ToString(), reader["LastName"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Tento zaměstnanec není uveden v databázi!");
                        }
                    }
                }
                connection.Close();
            }
            return employee;
        }

        /* public void Register(string username, string password)
         {
             using (SqlConnection connection = new SqlConnection(connectionstring))
             {
                 connection.Open();
                 using (SqlCommand command = connection.CreateCommand())
                 {
                     command.CommandText = "insert into Users values (@name, @idEmployee, Convert(varbinary(max), @passwordHash), Convert(varbinary(max), @passwordSalt))";
                     command.Parameters.AddWithValue ("name", username);
                     command.Parameters.AddWithValue("idEmployee", 1);
                     HashPassword(password);
                     command.Parameters.AddWithValue("passwordHash", PasswordHash);
                     command.Parameters.AddWithValue("passwordSalt", PasswordSalt);
                     command.ExecuteNonQuery();
                 }
                 connection.Close();
             }
         }*/
    }
}
