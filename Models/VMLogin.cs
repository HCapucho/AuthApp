﻿namespace AuthApp.Models
{
    public class VMLogin
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public bool KeepLoggedIn { get; set; }
    }
}
