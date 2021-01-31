namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StoreNumber = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Privilege = c.String(),
                        position_PositionId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Position", t => t.position_PositionId)
                .Index(t => t.position_PositionId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        PositionId = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        ShiftId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UserId_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.ShiftId)
                .ForeignKey("dbo.Employee", t => t.UserId_EmployeeId)
                .Index(t => t.UserId_EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shift", "UserId_EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "position_PositionId", "dbo.Position");
            DropIndex("dbo.Shift", new[] { "UserId_EmployeeId" });
            DropIndex("dbo.Employee", new[] { "position_PositionId" });
            DropTable("dbo.Shift");
            DropTable("dbo.Position");
            DropTable("dbo.Employee");
        }
    }
}
