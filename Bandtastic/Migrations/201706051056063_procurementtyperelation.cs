namespace Bandtastic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class procurementtyperelation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProcurementTypes", "ProcurementBand_ID", "dbo.ProcurementBands");
            DropIndex("dbo.ProcurementTypes", new[] { "ProcurementBand_ID" });
            RenameColumn(table: "dbo.ProcurementTypes", name: "ProcurementBand_ID", newName: "ProcurementBandID");
            AlterColumn("dbo.ProcurementTypes", "ProcurementBandID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProcurementTypes", "ProcurementBandID");
            AddForeignKey("dbo.ProcurementTypes", "ProcurementBandID", "dbo.ProcurementBands", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProcurementTypes", "ProcurementBandID", "dbo.ProcurementBands");
            DropIndex("dbo.ProcurementTypes", new[] { "ProcurementBandID" });
            AlterColumn("dbo.ProcurementTypes", "ProcurementBandID", c => c.Int());
            RenameColumn(table: "dbo.ProcurementTypes", name: "ProcurementBandID", newName: "ProcurementBand_ID");
            CreateIndex("dbo.ProcurementTypes", "ProcurementBand_ID");
            AddForeignKey("dbo.ProcurementTypes", "ProcurementBand_ID", "dbo.ProcurementBands", "ID");
        }
    }
}
