namespace CategoryProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCoumnINCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Status");
        }
    }
}
