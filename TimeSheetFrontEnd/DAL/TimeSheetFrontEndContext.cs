using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetFrontEnd.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TimeSheetFrontEnd.DAL
{
	public class TimeSheetFrontEndContext : DbContext
	{
		public TimeSheetFrontEndContext() : base("TimeSheetFrontEndContext")
		{

		}

		/// <summary>
		/// We need to pull in all the models to be set in the Db(Database)
		/// </summary>
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Shift> Shifts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Database.SetInitializer(new CreateDatabaseIfNotExists<TimeSheetContext>());
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}