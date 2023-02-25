using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

        private byte[] PasswordHash (string password)
        {
            using(var hmac = new HMACSHA512())
            {
                byte[] PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return PasswordHash;
            }
        }

    }
}
