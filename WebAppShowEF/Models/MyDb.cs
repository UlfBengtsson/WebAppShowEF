using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppShowEF.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("ConnectionName")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}