using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GymSoftApplication.Models
{
    public class UserContext : DbContext

    {
        public UserContext()
            :base("DefaultConnection")
        {
            
        }

        public DbSet<UserModel> UserModels { get; set; }
    }
}