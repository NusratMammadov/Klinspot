namespace Klinspot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescAddToServices : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Desc", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Desc");
        }
    }
}
