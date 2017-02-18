namespace EntityFramWrkSln.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestorePassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "PasswordA");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PasswordA", c => c.String());
            DropColumn("dbo.Users", "Password");
        }
    }
}
