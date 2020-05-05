namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PosterImageURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PosterURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PosterURL");
        }
    }
}
