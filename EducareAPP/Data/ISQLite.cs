using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EducareAPP.Data
{
   public interface ISQLite
    {
        SQLiteConnection GetConnection();
    
    }
}
 