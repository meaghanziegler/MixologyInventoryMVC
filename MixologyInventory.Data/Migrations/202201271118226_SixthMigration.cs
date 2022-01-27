namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mix", "TotalLiquid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mix", "TotalLiquid");
        }
    }
}
