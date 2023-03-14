using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zaverecny_projekt_Greplova
{
    public class User
    {
        public User(int id, string name, int idEmployee, int role)
        {
            Id = id;
            Name = name;
            IdEmployee = idEmployee;
            Role = role;
        }

        public User(string name, byte[] passwordHash, byte[] passwordSalt)
        {
            Name = name;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public int IdEmployee { get; set; }
        public int Id { get; set; }
        public int Role { get; set; }

        public bool VerifyPassword(string text)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }

        public void ResetPassword()
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("heslo"));
            }
        }
    }
}
