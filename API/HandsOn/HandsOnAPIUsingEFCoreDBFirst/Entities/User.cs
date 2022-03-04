using System;
using System.Collections.Generic;

#nullable disable

namespace HandsOnAPIUsingEFCoreDBFirst.Entities
{
    public partial class User
    {
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
