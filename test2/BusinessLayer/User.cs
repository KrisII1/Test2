using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 1)]
        public string LastName { get; set; }

        [Range(18,81)]
        public int Age { get; set; }

        [StringLength(20, MinimumLength = 1)]
        public string Username { get; set; }

        [StringLength(70, MinimumLength = 1)]
        public string Password { get; set; }

        [StringLength(20, MinimumLength = 1)]
        public string Email { get; set; }

        public List<User> Friends { get; set; }
      
        public List<Interest> Interests { get; set; }

        public User(string firstName, string lastName, int age, string username, string password, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Username = username;
            Password = password;
            Email = email;
            Friends = new List<User>();
            Interests = new List<Interest>();
        }

        private User()
        {
            Friends = new List<User>();
            Interests = new List<Interest>();
        }
    }
}
