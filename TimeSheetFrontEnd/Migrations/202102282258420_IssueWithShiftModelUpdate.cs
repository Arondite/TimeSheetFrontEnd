namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IssueWithShiftModelUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shift", "StartTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Shift", "EndTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shift", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Shift", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
