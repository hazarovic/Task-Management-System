using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
    
using TMS.Models;

namespace TMS.Context
{
    public class DBContext : DbContext
    {
        public DBContext() : base("name=DataSource")
        {
                            
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

    }
}