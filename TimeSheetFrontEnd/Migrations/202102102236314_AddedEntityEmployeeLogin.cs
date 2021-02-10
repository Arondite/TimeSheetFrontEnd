namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEntityEmployeeLogin : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.EmployeeLogin");
        }
    }
}
