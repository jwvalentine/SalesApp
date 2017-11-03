namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        RegionId = c.Int(nullable: false),
                        SalesTarget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 100),
                        UpdatedBy = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesRegions", t => t.RegionId)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.SalesRegions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Code = c.String(nullable: false, maxLength: 3),
                        SalesTarget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 100),
                        UpdatedBy = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        PersonId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 100),
                        UpdatedBy = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesPersons", t => t.PersonId)
                .ForeignKey("dbo.SalesRegions", t => t.RegionId)
                .Index(t => t.PersonId)
                .Index(t => t.RegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "RegionId", "dbo.SalesRegions");
            DropForeignKey("dbo.Sales", "PersonId", "dbo.SalesPersons");
            DropForeignKey("dbo.SalesPersons", "RegionId", "dbo.SalesRegions");
            DropIndex("dbo.Sales", new[] { "RegionId" });
            DropIndex("dbo.Sales", new[] { "PersonId" });
            DropIndex("dbo.SalesPersons", new[] { "RegionId" });
            DropTable("dbo.Sales");
            DropTable("dbo.SalesRegions");
            DropTable("dbo.SalesPersons");
        }
    }
}
