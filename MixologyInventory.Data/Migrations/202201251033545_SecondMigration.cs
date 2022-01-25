namespace MixologyInventory.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drink", "LiquidName1", c => c.String(nullable: false));
            AddColumn("dbo.Drink", "LiquidAmount1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName2", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName3", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount3", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName4", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount4", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName5", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount5", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName6", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount6", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName7", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount7", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName8", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount8", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName9", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount9", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName10", c => c.String());
            AddColumn("dbo.Drink", "LiquidAmount10", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Mix", "AmountOfDrink", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Drink", "LiquidName");
            DropColumn("dbo.Drink", "LiquidAmount");
            DropColumn("dbo.Mix", "Amount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mix", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Drink", "LiquidName", c => c.String(nullable: false));
            DropColumn("dbo.Mix", "AmountOfDrink");
            DropColumn("dbo.Drink", "LiquidAmount10");
            DropColumn("dbo.Drink", "LiquidName10");
            DropColumn("dbo.Drink", "LiquidAmount9");
            DropColumn("dbo.Drink", "LiquidName9");
            DropColumn("dbo.Drink", "LiquidAmount8");
            DropColumn("dbo.Drink", "LiquidName8");
            DropColumn("dbo.Drink", "LiquidAmount7");
            DropColumn("dbo.Drink", "LiquidName7");
            DropColumn("dbo.Drink", "LiquidAmount6");
            DropColumn("dbo.Drink", "LiquidName6");
            DropColumn("dbo.Drink", "LiquidAmount5");
            DropColumn("dbo.Drink", "LiquidName5");
            DropColumn("dbo.Drink", "LiquidAmount4");
            DropColumn("dbo.Drink", "LiquidName4");
            DropColumn("dbo.Drink", "LiquidAmount3");
            DropColumn("dbo.Drink", "LiquidName3");
            DropColumn("dbo.Drink", "LiquidAmount2");
            DropColumn("dbo.Drink", "LiquidName2");
            DropColumn("dbo.Drink", "LiquidAmount1");
            DropColumn("dbo.Drink", "LiquidName1");
        }
    }
}
