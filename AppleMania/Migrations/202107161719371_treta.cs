namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class treta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pads", "Width", c => c.String());
            AddColumn("dbo.Pads", "Height", c => c.String());
            AddColumn("dbo.Pads", "Weigth", c => c.String());
            AddColumn("dbo.Pads", "Memory", c => c.String());
            AddColumn("dbo.Pads", "Camera", c => c.String());
            AddColumn("dbo.Pads", "Speakers", c => c.String());
            AddColumn("dbo.Pads", "Os", c => c.String());
            AddColumn("dbo.Pads", "Chip", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pads", "Chip");
            DropColumn("dbo.Pads", "Os");
            DropColumn("dbo.Pads", "Speakers");
            DropColumn("dbo.Pads", "Camera");
            DropColumn("dbo.Pads", "Memory");
            DropColumn("dbo.Pads", "Weigth");
            DropColumn("dbo.Pads", "Height");
            DropColumn("dbo.Pads", "Width");
        }
    }
}
