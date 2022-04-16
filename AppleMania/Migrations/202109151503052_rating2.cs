namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rates", "User", c => c.String(nullable: false));
            AddColumn("dbo.Rates", "Date", c => c.String());
            AddColumn("dbo.Rates", "Rating", c => c.Int(nullable: false));
            AlterColumn("dbo.Rates", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rates", "Comment", c => c.String(nullable: false));
            DropColumn("dbo.Rates", "Rating");
            DropColumn("dbo.Rates", "Date");
            DropColumn("dbo.Rates", "User");
        }
    }
}
