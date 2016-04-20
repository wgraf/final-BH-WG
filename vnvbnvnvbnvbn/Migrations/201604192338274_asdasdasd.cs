namespace vnvbnvnvbnvbn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdasd : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.sendemaildatas", newName: "senddatas");
            AddColumn("dbo.senddatas", "temp", c => c.String());
            AddColumn("dbo.senddatas", "city", c => c.String());
            AddColumn("dbo.senddatas", "option", c => c.String());
            AddColumn("dbo.senddatas", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.senddatas", "Discriminator");
            DropColumn("dbo.senddatas", "option");
            DropColumn("dbo.senddatas", "city");
            DropColumn("dbo.senddatas", "temp");
            RenameTable(name: "dbo.senddatas", newName: "sendemaildatas");
        }
    }
}
