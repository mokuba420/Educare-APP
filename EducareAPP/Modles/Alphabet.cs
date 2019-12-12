using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducareAPP.Modles
{
    public class Alphabet
    {
        [PrimaryKey]

        [AutoIncrement]
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
    }
}
