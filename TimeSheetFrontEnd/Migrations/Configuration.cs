namespace TimeSheetFrontEnd.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using TimeSheetFrontEnd.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.TimeSheetFrontEndContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.TimeSheetFrontEndContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //if (!context.Employees.Any())
            //{
            //    var employees = new List<Employee>
            //    {
            //        new Employee{ EmployeeId = 1, FirstName = "Stephen", LastName = "Knotek", StoreNumber = 142, Nickname = "Mufasa", Username = "Arondite", Password = "Adidas4224!", Privilege = "Admin" }
            //    };
            //    context.Employees.AddRange(employees);
            //    context.SaveChanges();
            //}
            
            //var positions = new List<Position>
            //{
            //    new Position{ Description = "Relief Manager"},
            //    new Position{ Description = "CSM"},
            //    new Position{ Description = "Bookkeeper"},
            //    new Position{ Description = "Checker"},
            //    new Position{ Description = "Booth"},
            //    new Position{ Description = "Bagger"},
            //    new Position{ Description = "Stephen's Bitch"}
            //};
            //context.Positions.AddRange(positions);
            //context.SaveChanges();
            //if (!context.Shifts.Any())
            //{
            //    var shifts = new List<Shift>
            //    {
            //        new Shift{ Date = DateTime.Now.Date, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1)}
            //    };
            //    context.Shifts.AddRange(shifts);
            //    context.SaveChanges();
            //}
        }
    }
}
