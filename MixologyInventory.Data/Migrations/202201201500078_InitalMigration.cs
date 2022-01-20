namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mix", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mix", "Name");
        }
    }
}
