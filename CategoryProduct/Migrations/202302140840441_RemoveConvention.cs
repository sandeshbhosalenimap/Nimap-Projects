namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveConvention : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CategoryModels", newName: "Categories");
            RenameTable(name: "dbo.ProductModels", newName: "Products");
            RenameTable(name: "dbo.LogInCredentialModels", newName: "LogInCredentials");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.LogInCredentials", newName: "LogInCredentialModels");
            RenameTable(name: "dbo.Products", newName: "ProductModels");
            RenameTable(name: "dbo.Categories", newName: "CategoryModels");
        }
    }
}
