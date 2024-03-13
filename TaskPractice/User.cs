﻿using TaskPractice.Interfaces;
using TaskPractice.Utils.Enums;

namespace TaskPractice
{
    internal class User : IEntity
    {
        private static int idCount = 1;
        public int Id { get; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Username);
            Console.WriteLine(Email);
            Console.WriteLine(Role);
        }
        public User(string username, string email, Role role)
        {
            Id= idCount++;
            Username = username;
            Email = email;
            Role = role;

        }
    }
}
