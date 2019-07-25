namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TextAddToAboutText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AboutTexts", "Text", c => c.String(storeType: "ntext"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AboutTexts", "Text");
        }
    }
}
