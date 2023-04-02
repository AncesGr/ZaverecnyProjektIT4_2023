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
                            user = new User(Convert.ToInt32(reader["IdUser"]), reader["Name"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"]);
                        }
                        else
                        {
                            MessageBox.Show("User with that username doesnt exist!");
                        }
                    }
                }
                connection.Close();
            }
            return user;
        }

        public User GetUser(int id)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Users where IdUser=@id";
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(Convert.ToInt32(reader["IdUser"]), Convert.ToString(reader["Name"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"]));
                        }
                        else
                        {
                            MessageBox.Show("User with that username doesnt exist!");
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
                            users.Add(new User(Convert.ToInt32(reader["IdUser"]),reader["Name"].ToString(), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["Role"])));
                        }
                    }
                }
                connection.Close();
            }
            return users;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Employee";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employees.Add(new Employee(Convert.ToDateTime(reader["BirthDate"]), reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), reader["Email"].ToString(), reader["PhoneNumber"].ToString()));
                        }
                    }
                }
                connection.Close();
            }
            return employees;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Roles";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(new Role(reader["Name"].ToString(),(int)reader["IdRoles"]));
                        }
                    }
                }
                connection.Close();
            }
            return roles;
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
                            employee = new Employee((DateTime)reader["BirthDate"], reader["FirstName"].ToString(), reader["LastName"].ToString(), Convert.ToInt32(reader["IdEmployee"]), reader["Email"].ToString(), reader["PhoneNumber"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("This user is not in the database!");
                        }
                    }
                }
                connection.Close();
            }
            return employee;
        }

        public void UpdateEmployee(int idEmployee, string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Employee set FirstName=@firstName,LastName=@lastName,BirthDate=@birthDate,Email=@email,PhoneNumber=@phone where IdEmployee=@idEmployee";
                    command.Parameters.AddWithValue("firstName", firstName);
                    command.Parameters.AddWithValue("lastName", lastName);
                    command.Parameters.AddWithValue("birthDate", birthDate);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("phone", phone);
                    command.Parameters.AddWithValue("idEmployee", idEmployee);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddEmployee(string firstName, string lastName, DateTime birthDate, string email, string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into Employee values (@firstName,@lastName,@birthDate,@email, @phone)";
                    command.Parameters.AddWithValue("firstName", firstName);
                    command.Parameters.AddWithValue("lastName", lastName);
                    command.Parameters.AddWithValue("birthDate", birthDate);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("phone", phone);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteEmployee(int idEmployee)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Employee where IdEmployee=@idEmployee";
                    command.Parameters.AddWithValue("IdEmployee", idEmployee);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public Role GetRole(int idRole)
        {
            Role role = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Roles where IdRoles=@id";
                    command.Parameters.AddWithValue("id", idRole);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(reader["Name"].ToString(), (int)reader["IdRoles"]);
                        }
                        else
                        {
                            MessageBox.Show("This role doesnt exist!");
                        }
                    }
                }
                connection.Close();
            }
            return role;
        }

        public Role GetRole(string nameRole)
        {
            Role role = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Roles where Name=@nameRole";
                    command.Parameters.AddWithValue("nameRole", nameRole);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = new Role(Convert.ToString(reader["Name"]),(int)reader["IdRoles"]);
                        }
                        else
                        {
                            MessageBox.Show("This role doesnt exist!");
                        }
                    }
                }
                connection.Close();
            }
            return role;
        }

        public void UpdateUser(string username, int idRole, int idUser)
        {
            using(SqlConnection connection = new SqlConnection(connectionstring)) 
            { 
                connection.Open();
                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Users set Name=@username,Role=@idRole where IdUser=@idUser";
                    command.Parameters.AddWithValue("username", username);
                    command.Parameters.AddWithValue("idRole", idRole);
                    command.Parameters.AddWithValue("idUser", idUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void ResetUserPassword(int idUser, byte[] passwordHash, byte[] passwordSalt)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Users set PasswordHash=@passwordHash,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    command.Parameters.AddWithValue("passwordHash", passwordHash);
                    command.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    command.Parameters.AddWithValue("idUser", idUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void ChangeUserPassword(int idUser, byte[] passwordHash, byte[] passwordSalt)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Users set PasswordHash=@passwordHash,PasswordSalt=@passwordSalt where IdUser=@idUser";
                    command.Parameters.AddWithValue("passwordHash", passwordHash);
                    command.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    command.Parameters.AddWithValue("idUser", idUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddUser(string name, int idEmployee, byte[] passwordHash, byte[] passwordSalt, int role)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into Users values (@name, @idEmployee, @passwordHash, @passwordSalt, @role)";
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("idEmployee", idEmployee);
                    command.Parameters.AddWithValue("passwordHash", passwordHash);
                    command.Parameters.AddWithValue("passwordSalt", passwordSalt);
                    command.Parameters.AddWithValue("role", role);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteUser(int idUser)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Users where IdUser=@idUser";
                    command.Parameters.AddWithValue("idUser", idUser);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void UpdateRole(int idRole, string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Roles set Name=@name where IdRoles=@idRoles";
                    command.Parameters.AddWithValue("Name", name);
                    command.Parameters.AddWithValue("IdRoles", idRole);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteRole(int idRole)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Roles where IdRoles=@IdRoles";
                    command.Parameters.AddWithValue("IdRoles", idRole);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddRole(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into Roles values (@Name)";
                    command.Parameters.AddWithValue("Name", name);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<Contract> GetContracts()
        {
            List<Contract> contracts = new List<Contract>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Contract";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contracts.Add(new Contract(Convert.ToInt32(reader["IdContract"]), reader["Customer"].ToString(), reader["Description"].ToString()));
                        }
                    }
                }
                connection.Close();
            }
            return contracts;
        }

        public Contract GetContract(int idContract)
        {
            Contract contract = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Contract where IdContract=@idContract";
                    command.Parameters.Add("idContract", idContract);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            contract = new Contract(Convert.ToInt32(reader["IdContract"]), reader["Customer"].ToString(), reader["Description"].ToString());
                        }
                    }
                }
                connection.Close();
            }
            return contract;
        }

        public void UpdateContract(int idContract, string customer, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update Contract set Customer=@customer, Description=@description where IdContract=@idContract";
                    command.Parameters.AddWithValue("customer", customer);
                    command.Parameters.AddWithValue("description", description);
                    command.Parameters.AddWithValue("idContract", idContract);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddContract(string customer, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into Contract values (@Customer, @Description)";
                    command.Parameters.AddWithValue("Customer", customer); 
                    command.Parameters.AddWithValue("Description", description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteContract(int idContract)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from Contract where IdContract=@idContract";
                    command.Parameters.AddWithValue("idContract", idContract);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public List<WorkType> GetWorkTypes()
        {
            List<WorkType> workTypes = new List<WorkType>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from WorkType";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workTypes.Add(new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString()));
                        }
                    }
                }
                connection.Close();
            }
            return workTypes;
        }

        public WorkType GetWorkType(int idWorkType)
        {
            WorkType workType = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from WorkType where IdWorkType=@idWorkType";
                    command.Parameters.AddWithValue("idWorkType", idWorkType);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workType = new WorkType(Convert.ToInt32(reader["IdWorkType"]), reader["Name"].ToString(), reader["Description"].ToString());
                        }
                    }
                }
                connection.Close();
            }
            return workType;
        }

        public void UpdateWorkType(string name, string descrtiption, int idWorkType)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update WorkType set Name=@name, Description=@description where IdWorkType=@idWorkType";
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("description", descrtiption);
                    command.Parameters.AddWithValue("idWorkType", idWorkType);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddWorkType(string name, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into WorkType values (@name,@description)";
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("description", description);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteWorkType(int idWork)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from WorkType where IdWorkType=@idWorkType";
                    command.Parameters.AddWithValue("idWorkType", idWork);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

         public List<WorkHours> GetWorkHours()
         {
            List<WorkHours> workHours = new List<WorkHours>();
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from WorkHours";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            workHours.Add(new WorkHours(Convert.ToInt32(reader["IdWorkHours"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["IdContact"]), Convert.ToInt32(reader["Hours"])));
                        }
                    }
                }
                connection.Close();
            }
            return workHours;
         }

        public WorkHours GetWorkHour(int idWorkHour)
        {
            WorkHours workHours = null;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "select * from WorkHours where IdWorkHours=@idWorkHours";
                    command.Parameters.AddWithValue("idWorkHours", idWorkHour);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            workHours = new WorkHours(Convert.ToInt32(reader["IdWorkHours"]), Convert.ToInt32(reader["IdEmployee"]), Convert.ToInt32(reader["IdContact"]), Convert.ToInt32(reader["Hours"]));
                        }
                    }
                }
                connection.Close();
            }
            return workHours;
        }

        public void UpdateWorkHours(int idWorkHours, int idEmployee, int idContact, int hours)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "update WorkHours set IdEmployee=@idEmployee, IdContact=@idContact, Hours=@hours where IdWorkHours=@idWorkHours";
                    command.Parameters.AddWithValue("IdEmployee", idEmployee);
                    command.Parameters.AddWithValue("IdContact", idContact);
                    command.Parameters.AddWithValue("Hours", hours);
                    command.Parameters.AddWithValue("IdWorkHours", idWorkHours);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void AddWorkHours(int hours)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "insert into WorkHours values (@hours)";
                    command.Parameters.AddWithValue("Hours", hours);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void DeleteWorkHours(int idWorkHours)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "delete from WorkHours where IdWorkHours=@idWorkHours";
                    command.Parameters.AddWithValue("idWorkHours", idWorkHours);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
