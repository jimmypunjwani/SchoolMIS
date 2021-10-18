namespace SchoolMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatethefieldNameBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "BirhtDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "BirhtDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
