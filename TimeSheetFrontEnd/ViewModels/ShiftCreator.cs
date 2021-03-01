using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetFrontEnd.Models;

namespace TimeSheetFrontEnd.ViewModels
{
	public class ShiftCreator
	{
		public List<Employee> Employees { get; set; }
		public List<Shift> Shifts { get; set; }
		public ShiftCreator() : this(null, null)
		{

		}
		public ShiftCreator(List<Employee> employee, List<Shift> shifts)
		{
			Employees = employee;
			Shifts = shifts;
		}
		public Shift CreateShiftInDatabase(TimeSpan startTime, TimeSpan endTime, string Employee)
		{

			return null;
		}

	}
}