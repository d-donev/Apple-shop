namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rating21 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rates", "User", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rates", "User", c => c.String(nullable: false));
        }
    }
}
