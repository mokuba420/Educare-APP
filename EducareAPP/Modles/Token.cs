﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducareAPP.Modles
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string acces_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }

        public Token () { }

    }
}
