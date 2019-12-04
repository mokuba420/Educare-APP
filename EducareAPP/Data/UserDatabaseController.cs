using EducareAPP.Modles;
using Microsoft.EntityFrameworkCore.Storage;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EducareAPP.Data
{
  public class UserDatabaseController
  {
        static object locker = new Object();

        SQLiteConnection datebase;

        public UserDatabaseController()
        {
            datebase = DependencyService.Get<ISQLite>().GetConnection();
            datebase.CreateTable<User>();
        }

        public User GetUser()
        {
            lock (locker)
            {
                if (datebase.Table<User>().Count() == 0)
                {
                    return null;        
                }
                else
                {
                    return datebase.Table<User>().First();
                }
             }            
        }
        public int SaveUser(User user)
        {
            lock (locker)
            {
                if (user.Id != 0) 
                {
                    datebase.Update(user);
                 return user.Id;
                }
                else
                {
                    return datebase.Insert(user);
                }
            }
                    
        }
        public int DeleteUser(int id) 
        {
            lock (locker)
            {
                return datebase.Delete<User>(id);
            }
                    
        }
    }

}
