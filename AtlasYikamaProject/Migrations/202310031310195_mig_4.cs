namespace AtlasYikamaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutPages",
                c => new
                    {
                        AboutPageID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Title2 = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.AboutPageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AboutPages");
        }
    }
}
