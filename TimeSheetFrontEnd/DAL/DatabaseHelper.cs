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
		public List<Shift> ListOfShifts()
		{
			List<Shift> shifts = new List<Shift>();
			shifts = context.Shift.ToList();
			return shifts;
		}
		public List<Shift> ReturnShiftsOnGivenDate(DateTime givenDate)
		{
			List<Shift> shifts = new List<Shift>();
			shifts = context.Shift.Where(d => d.DateOfShift = givenDate).ToList();
			return shifts;
		}

	}
}