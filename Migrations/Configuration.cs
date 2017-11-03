namespace SalesApp.Migrations
{
    using SalesApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesApp.Data.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SalesApp.Data.SalesContext context)
        {
            context.Regions.AddOrUpdate(
             p => p.Id,
             new SalesRegion
             {
                 Active = true,
                 Code = "NTH",
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 Id = 1,
                 Name = "North Region",
                 SalesTarget = 10000.00M,
                 UpdatedBy = "Admin",
                 UpdatedDate = DateTime.Now
             },
             new SalesRegion
             {
                 Active = true,
                 Code = "STH",
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 Id = 2,
                 Name = "South Region",
                 SalesTarget = 10000.00M,
                 UpdatedBy = "Admin",
                 UpdatedDate = DateTime.Now
             });


            context.People.AddOrUpdate(
             p => p.Id,
             new SalesPerson
             {
                Active = true,
                FirstName = "Bob",
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                Id = 1,
                LastName = "Smith",
                SalesTarget = 2000.00M,
                UpdatedBy = "Admin",
                UpdatedDate = DateTime.Now,
                RegionId = 1

             });

            context.Sales.AddOrUpdate(
             p => p.Id,
             new Sale
             {
                 Amount = 321.45M,
                 CreatedBy = "Admin",
                 CreatedDate = DateTime.Now,
                 Id = 1,
                 Date = new DateTime(2017, 11, 1),
                 UpdatedDate = DateTime.Now,
                 RegionId = 1,
                 PersonId = 1, 
             });


        }
    }
}