using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetFrontEnd.Models;
using TimeSheetFrontEnd.DAL;

namespace TimeSheetFrontEnd.DAL
{
	public class DatabaseHelper
	{
		private TimeSheetFrontEndContext context = new TimeSheetFrontEndContext();
		public List<Employee> ListOfEmployees()
		{
			List<Employee> employees = new List<Employee>();
			employees = context.Employees.ToList();
			return employees;
		}

	}
}