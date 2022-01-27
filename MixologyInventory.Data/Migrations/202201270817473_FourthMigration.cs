namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Liquid", "Mix_ID", c => c.Int());
            CreateIndex("dbo.Liquid", "Mix_ID");
            AddForeignKey("dbo.Liquid", "Mix_ID", "dbo.Mix", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Liquid", "Mix_ID", "dbo.Mix");
            DropIndex("dbo.Liquid", new[] { "Mix_ID" });
            DropColumn("dbo.Liquid", "Mix_ID");
        }
    }
}
