namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeventhMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Mix", "TotalLiquid");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mix", "TotalLiquid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
