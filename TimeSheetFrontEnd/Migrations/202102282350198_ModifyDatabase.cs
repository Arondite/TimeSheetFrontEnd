namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shift", "Employee", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Shift", "Employee");
        }
    }
}
