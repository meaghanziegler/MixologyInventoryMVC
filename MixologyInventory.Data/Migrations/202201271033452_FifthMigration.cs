namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Liquid", "Mix_ID", "dbo.Mix");
            DropIndex("dbo.Liquid", new[] { "Mix_ID" });
            AddColumn("dbo.Drink", "LiquidName", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Liquid", "Mix_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Liquid", "Mix_ID", c => c.Int());
            DropColumn("dbo.Drink", "LiquidAmount");
            DropColumn("dbo.Drink", "LiquidName");
            CreateIndex("dbo.Liquid", "Mix_ID");
            AddForeignKey("dbo.Liquid", "Mix_ID", "dbo.Mix", "ID");
        }
    }
}
