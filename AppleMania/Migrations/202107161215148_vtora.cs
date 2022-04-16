namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vtora : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Phones", "Dimensions", c => c.String());
            AddColumn("dbo.Phones", "DisplaySize", c => c.String());
            AddColumn("dbo.Phones", "Sim", c => c.String());
            AddColumn("dbo.Phones", "Os", c => c.String());
            AddColumn("dbo.Phones", "Memory", c => c.String());
            AddColumn("dbo.Phones", "BackCamera", c => c.String());
            AddColumn("dbo.Phones", "FrontCamera", c => c.String());
            AddColumn("dbo.Phones", "Battery", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Phones", "Battery");
            DropColumn("dbo.Phones", "FrontCamera");
            DropColumn("dbo.Phones", "BackCamera");
            DropColumn("dbo.Phones", "Memory");
            DropColumn("dbo.Phones", "Os");
            DropColumn("dbo.Phones", "Sim");
            DropColumn("dbo.Phones", "DisplaySize");
            DropColumn("dbo.Phones", "Dimensions");
        }
    }
}
