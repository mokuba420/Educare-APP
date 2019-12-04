using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducareAPP.Modles
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string text) { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool CheckInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
            return false;
        }
    }
}
