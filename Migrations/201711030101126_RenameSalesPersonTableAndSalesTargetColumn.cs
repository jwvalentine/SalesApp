namespace SalesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameSalesPersonTableAndSalesTargetColumn : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.SalesPersons", newName: "SalesPeople");
            RenameColumn(table: "dbo.SalesPeople", name: "SalesTarget", newName: "Target");
            AddColumn("dbo.Sales", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sales", "Status");
            RenameColumn(table: "dbo.SalesPeople", name: "Target", newName: "SalesTarget");
            RenameTable(name: "dbo.SalesPeople", newName: "SalesPersons");
        }
    }
}
