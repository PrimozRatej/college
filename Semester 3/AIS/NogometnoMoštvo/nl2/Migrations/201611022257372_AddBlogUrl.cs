namespace nl2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogUrl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Transakcijas", "datum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transakcijas", "datum", c => c.String());
        }
    }
}
