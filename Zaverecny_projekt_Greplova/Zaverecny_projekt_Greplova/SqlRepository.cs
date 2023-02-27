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
        public SqlRepository(string connectionstring)
        {
            this.connectionstring = connectionstring;
        }

        public string connectionstring { get; set; }
        byte[] PasswordSalt;
        byte[] PasswordHash;

        public void Login (string username, string password) 
        {
            using (SqlConnection connection = new SqlConnection(connectionstring)) 
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand()) 
                {
                    command.CommandText = "select *  from Users where Name=@username ";
                    command.Parameters.AddWithValue("username", username);
                   // password=Convert.ToString(PasswordHash(password));
                    //command.Parameters.AddWithValue("password", password);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                            MessageBox.Show("nevim!" + dataReader["Name"]);
                        }
                    }
                }
                connection.Close();
            }
        }

        public void Register(string username, string password)
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
        }

        private void HashPassword (string password)
        {
            using(var hmac = new HMACSHA512())
            {
               PasswordSalt = hmac.Key;
               PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }

    }
}
