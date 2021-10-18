namespace SchoolMIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDatetoIdentityModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirhtDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirhtDate");
        }
    }
}
