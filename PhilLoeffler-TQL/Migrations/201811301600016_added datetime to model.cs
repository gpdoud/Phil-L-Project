namespace PhilLoeffler_TQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddatetimetomodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Results", "DateCreated");
        }
    }
}
