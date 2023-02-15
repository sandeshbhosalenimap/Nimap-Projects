namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductColoumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCreatedBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductCreatedBy");
        }
    }
}
