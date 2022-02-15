using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FYMKWebApplication4.Data
{
    public class FYMKWebApplication4Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FYMKWebApplication4Context() : base("name=FYMKWebApplication4Context")
        {
        }

        public System.Data.Entity.DbSet<FYMKWebApplication4.Models.Mentee> Mentees { get; set; }

        public System.Data.Entity.DbSet<FYMKWebApplication4.Models.Mentor> Mentors { get; set; }
    }
}
