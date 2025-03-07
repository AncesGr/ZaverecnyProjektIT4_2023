﻿using System;
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

        public User(int id, string name, byte[] passwordHash, byte[] passwordSalt)
        {
            Id = id;
            Name = name;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }

        public User(string name)
        {
            Name = name;
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
            HashPassword("heslo");
        }

        public void ChangePassword(string password)
        {
            HashPassword(password);
        }

        private void HashPassword(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
