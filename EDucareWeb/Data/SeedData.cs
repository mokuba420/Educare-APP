using EDucareWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDucareWeb.Data
{
    public class SeedData
    {
        public static void Initialize(information context)
        {
            if (!context.UserInformation.Any())
            {
                context.UserInformation.AddRange(
                    new UserInformation
                    {

                        UserName = "Kai",
                        Password = "Apples123",
                       
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
