using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Remote_Work.Models
{
    public class RemoteContext : DbContext
    {
       public RemoteContext():base("Name=RemoteContext")
        {

        }

       public DbSet<Dummy> Dummies { get; set; }
        public DbSet<uzair> Uzairs { get; set; }


    }
}