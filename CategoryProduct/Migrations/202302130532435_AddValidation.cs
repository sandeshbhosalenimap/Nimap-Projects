namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LogInCredentials", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.LogInCredentials", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.LogInCredentials", "Role", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogInCredentials", "Role", c => c.String());
            AlterColumn("dbo.LogInCredentials", "Password", c => c.String());
            AlterColumn("dbo.LogInCredentials", "UserName", c => c.String());
        }
    }
}
