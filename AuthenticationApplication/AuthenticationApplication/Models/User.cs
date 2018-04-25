﻿namespace AuthenticationApplication.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool AcceptedTnC { get; set; }
    }
}