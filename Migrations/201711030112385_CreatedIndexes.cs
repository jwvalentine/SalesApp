namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedIndexes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SalesPeople", new[] { "LastName", "FirstName" }, name: "FullName");
            CreateIndex("dbo.SalesRegions", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.SalesRegions", new[] { "Name" });
            DropIndex("dbo.SalesPeople", "FullName");
        }
    }
}
