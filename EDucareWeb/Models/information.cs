using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDucareWeb.Models
{
    public class information : DbContext
    {
    

        public information(DbContextOptions<information> options)
            : base(options)
        {
        }

        public DbSet<UserInformation> UserInformation { get; set; }
    }   
}