using System;

namespace Core3App_EF6.Model
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Password { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Bio { get; set; }
    }
}