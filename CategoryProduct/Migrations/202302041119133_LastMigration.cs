namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LogInCredentials", "Roles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LogInCredentials", "Roles");
        }
    }
}
