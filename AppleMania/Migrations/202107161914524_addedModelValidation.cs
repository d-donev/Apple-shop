namespace AppleMania.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedModelValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pads", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Pads", "ReleaseDate", c => c.String(nullable: false));
            AlterColumn("dbo.Phones", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.Phones", "ReleaseDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Phones", "Model", c => c.String());
            AlterColumn("dbo.Pads", "ReleaseDate", c => c.String());
            AlterColumn("dbo.Pads", "Model", c => c.String());
        }
    }
}
