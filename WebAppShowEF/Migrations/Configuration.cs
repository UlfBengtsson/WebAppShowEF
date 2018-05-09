namespace WebAppShowEF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebAppShowEF.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppShowEF.Models.MyDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAppShowEF.Models.MyDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Cars.AddOrUpdate( c => c.Model,
                 new Car { Brand = "Saab", Model = "900", Year = 1978 },
                 new Car { Brand = "Saab", Model = "9000", Year = 1988 },
                 new Car { Brand = "Volvo", Model = "740", Year = 1978},
                 new Car { Brand = "Volvo", Model = "240", Year = 1972 },
                 new Car { Brand = "Volvo", Model = "Amazon", Year = 1962 },
                 new Car { Brand = "Opel", Model = "Kadett", Year = 1969 },
                 new Car { Brand = "Subaru", Model = "Impreza", Year = 1992 }
                );
        }
    }
}
