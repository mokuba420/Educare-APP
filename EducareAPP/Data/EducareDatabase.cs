using EducareAPP.Modles;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EducareAPP.Data
{
    public class EducareDatabase
    {
            readonly SQLiteAsyncConnection database;

            public EducareDatabase(string dbPath)
            {
                database = new SQLiteAsyncConnection(dbPath);
                database.CreateTableAsync<User>().Wait();
            }

            public Task<List<User>> GetItemsAsync()
            {
                return database.Table<User>().ToListAsync();
            }

            public Task<List<User>> GetItemsNotDoneAsync()
            {
                return database.QueryAsync<User>("SELECT * FROM [EducareDatabase] WHERE [Done] = 0");
            }

            public Task<User> GetItemAsync(int id)
            {
                return database.Table<User>().Where(i => i.Id == id).FirstOrDefaultAsync();
            }

            public Task<int> SaveItemAsync(User item)
            {
                if (item.Id != 0)
                {
                    return database.UpdateAsync(item);
                }
                else
                {
                    return database.InsertAsync(item);
                }
            }

            public Task<int> DeleteItemAsync(User item)
            {
                return database.DeleteAsync(item);
            }
          public List<Alphabet> GetAlphabetList()
          {
            var returnList = new List<Alphabet>();
            var alphabet = new Alphabet();         
            alphabet.ImageName = "AisforApple.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "bisforball.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();       
            alphabet.ImageName = "cisforcat.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "disfordog.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "EisforEgg.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "fisforfish.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();      
            alphabet.ImageName = "gisforgoat.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();  
            alphabet.ImageName = "hisforhat.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "iisforink.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "jisforjelly.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "kisforkite.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "lisforlion.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "misformonkey.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "nisfornose.JPG";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "oisfororange.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "sisforsun.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();      
            alphabet.ImageName = "tisfortiger.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "uisforumbrella.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "visforvan.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "wisforwalrus.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "xisforxylophone.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "Yisforyellow.jpg";
            returnList.Add(alphabet);
            alphabet = new Alphabet();
            alphabet.ImageName = "ziszebra.jpg";
            returnList.Add(alphabet);
            return returnList;
          }
    }
}

 