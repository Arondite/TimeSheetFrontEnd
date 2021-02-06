namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameToEmployeeEntityTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Nickname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Nickname");
        }
    }
}
