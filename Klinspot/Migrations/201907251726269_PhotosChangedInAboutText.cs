namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotosChangedInAboutText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AboutTexts", "Photo", c => c.String(maxLength: 100));
            DropColumn("dbo.AboutTexts", "PhotoLarge");
            DropColumn("dbo.AboutTexts", "PhotoRightTop");
            DropColumn("dbo.AboutTexts", "PhotoRightBottom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AboutTexts", "PhotoRightBottom", c => c.String(maxLength: 100));
            AddColumn("dbo.AboutTexts", "PhotoRightTop", c => c.String(maxLength: 100));
            AddColumn("dbo.AboutTexts", "PhotoLarge", c => c.String(maxLength: 100));
            DropColumn("dbo.AboutTexts", "Photo");
        }
    }
}
