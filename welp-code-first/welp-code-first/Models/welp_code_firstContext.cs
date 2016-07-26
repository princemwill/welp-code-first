using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class welp_code_firstContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        //public welp_code_firstContext() : base("name=welp_code_firstContext")
        //{
        //}

        //public System.Data.Entity.DbSet<welp_code_first.Models.User> Users { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<BusinessType> BusinessTypes { get; set; }

    }
}
