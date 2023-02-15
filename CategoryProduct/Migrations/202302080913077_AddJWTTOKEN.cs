namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJWTTOKEN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogInCredentials", "Role", c => c.String());
            DropColumn("dbo.LogInCredentials", "Roles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogInCredentials", "Roles", c => c.String());
            DropColumn("dbo.LogInCredentials", "Role");
        }
    }
}
