using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EducareAPP.Data;
using EducareAPP.iOS.Data;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace EducareAPP.iOS.Data
{
   public class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
       public SQLite.SQLiteConnection GetConnection() 
        {
            var fileName = "Test.db.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library")
            var path = path.Combine(libarayPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }


    }
}