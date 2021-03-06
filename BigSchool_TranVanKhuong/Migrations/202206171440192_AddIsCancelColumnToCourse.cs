namespace BigSchool_TranVanKhuong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCancelColumnToCourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "IsCanceled");
        }
    }
}
