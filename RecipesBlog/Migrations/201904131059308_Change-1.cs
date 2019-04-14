namespace RecipesBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recipes", "Description", c => c.String(maxLength: 1000));
            DropColumn("dbo.Recipes", "Calories");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Recipes", "Calories", c => c.Double(nullable: false));
            DropColumn("dbo.Recipes", "Description");
        }
    }
}
