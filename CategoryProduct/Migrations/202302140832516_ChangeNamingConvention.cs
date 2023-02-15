namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNamingConvention : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "CategoryModels");
            RenameTable(name: "dbo.Products", newName: "ProductModels");
            RenameTable(name: "dbo.LogInCredentials", newName: "LogInCredentialModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.LogInCredentialModels", newName: "LogInCredentials");
            RenameTable(name: "dbo.ProductModels", newName: "Products");
            RenameTable(name: "dbo.CategoryModels", newName: "Categories");
        }
    }
}
