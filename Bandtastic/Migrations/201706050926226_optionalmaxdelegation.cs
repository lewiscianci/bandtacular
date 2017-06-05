namespace Bandtastic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optionalmaxdelegation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProcurementTypes", "MaxDelegation", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProcurementTypes", "MaxDelegation", c => c.Int(nullable: false));
        }
    }
}
