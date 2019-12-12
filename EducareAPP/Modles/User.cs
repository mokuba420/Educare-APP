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
     
        
    }
}
