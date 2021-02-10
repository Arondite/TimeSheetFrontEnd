namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TookAwayEntityTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EmployeeLogin");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeLogin",
                c => new
                    {
                        PersonalId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Privalege = c.String(),
                    })
                .PrimaryKey(t => t.PersonalId);
            
        }
    }
}
