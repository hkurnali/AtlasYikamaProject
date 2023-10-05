namespace AtlasYikamaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_3 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.HeadSladers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HeadSladers",
                c => new
                    {
                        HeadSladerID = c.Int(nullable: false, identity: true),
                        Image1 = c.String(),
                        Image2 = c.String(),
                        Image3 = c.String(),
                    })
                .PrimaryKey(t => t.HeadSladerID);
            
        }
    }
}
