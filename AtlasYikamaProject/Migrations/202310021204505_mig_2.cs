namespace AtlasYikamaProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.About2", "BackGrandIMG");
        }
        
        public override void Down()
        {
            AddColumn("dbo.About2", "BackGrandIMG", c => c.String());
        }
    }
}
