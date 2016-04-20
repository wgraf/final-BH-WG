namespace vnvbnvnvbnvbn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pogoda : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.senddatas", "defaulttemp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.senddatas", "defaulttemp", c => c.Double(nullable: false));
        }
    }
}
