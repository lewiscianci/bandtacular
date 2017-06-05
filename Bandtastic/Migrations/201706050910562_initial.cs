namespace Bandtastic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FinancialBands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProcurementTypeID = c.Int(nullable: false),
                        Recurrent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProcurementTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MaxDelegation = c.Int(nullable: false),
                        FinancialBand_ID = c.Int(),
                        ProcurementBand_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FinancialBands", t => t.FinancialBand_ID)
                .ForeignKey("dbo.ProcurementBands", t => t.ProcurementBand_ID)
                .Index(t => t.FinancialBand_ID)
                .Index(t => t.ProcurementBand_ID);
            
            CreateTable(
                "dbo.ProcurementBands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProcurementTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcurementTypes", "ProcurementBand_ID", "dbo.ProcurementBands");
            DropForeignKey("dbo.ProcurementTypes", "FinancialBand_ID", "dbo.FinancialBands");
            DropIndex("dbo.ProcurementTypes", new[] { "ProcurementBand_ID" });
            DropIndex("dbo.ProcurementTypes", new[] { "FinancialBand_ID" });
            DropTable("dbo.ProcurementBands");
            DropTable("dbo.ProcurementTypes");
            DropTable("dbo.FinancialBands");
        }
    }
}
