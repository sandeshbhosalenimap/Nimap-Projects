namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductCreatedBy", c => c.String(nullable: false));
            AlterColumn("dbo.LogInCredentials", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.LogInCredentials", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.LogInCredentials", "Role", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LogInCredentials", "Role", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.LogInCredentials", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.LogInCredentials", "UserName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "ProductCreatedBy", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
