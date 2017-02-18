namespace EntityFramWrkSln.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addproperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "MyProperty");
        }
    }
}
