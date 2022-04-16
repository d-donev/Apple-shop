namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCartUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhoneForUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneName = c.String(),
                        PhoneId = c.Int(nullable: false),
                        UserId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhoneForUsers");
        }
    }
}
