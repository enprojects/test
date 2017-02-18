namespace EntityFramWrkSln.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePassword : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PasswordA", c => c.String());
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Users", "PasswordA");
        }
    }
}
