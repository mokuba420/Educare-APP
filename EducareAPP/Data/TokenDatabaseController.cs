using EducareAPP.Modles;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EducareAPP.Data
{
  public  class TokenDatabaseController
  {
        static object locker = new Object();

        SQLiteConnection datebase;
        
        public TokenDatabaseController()
        {
            datebase = DependencyService.Get<ISQLite>().GetConnection();
            datebase.CreateTable<User>();
        }

        public Token GetToken()
        {
            lock (locker)
            {
                if (datebase.Table<Token>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return datebase.Table<Token>().First();
                }
            }
        }
        public int SaveTokenr(Token Token)
        {
            lock (locker)
            {
                if (Token.Id != 0)
                {
                    datebase.Update(Token);
                    return Token.Id;
                }
                else
                {
                    return datebase.Insert(Token);
                }
            }

        }
        public int DeleteToken(int id)
        {
            lock (locker)
            {
                return datebase.Delete<Token>(id);
            }

        }
    }

}
