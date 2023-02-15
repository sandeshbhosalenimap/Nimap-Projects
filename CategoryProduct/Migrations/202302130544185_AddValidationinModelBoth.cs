namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationinModelBoth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "ProductCreatedBy", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductCreatedBy", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
        }
    }
}
