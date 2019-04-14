namespace RecipesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change41 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Recipes");
            AlterColumn("dbo.Recipes", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Recipes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Recipes");
            AlterColumn("dbo.Recipes", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Recipes", "Id");
        }
    }
}
