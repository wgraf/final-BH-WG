namespace vnvbnvnvbnvbn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cokolwiek : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sendemaildatas",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        url = c.String(),
                        address = c.String(),
                        text = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sendemaildatas");
        }
    }
}
