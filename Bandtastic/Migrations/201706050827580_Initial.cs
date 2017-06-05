namespace Bandtastic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinancialBands",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        MaxDelegation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProcurementBands",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(),
                        MaxDelegation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProcurementBands");
            DropTable("dbo.FinancialBands");
        }
    }
}
