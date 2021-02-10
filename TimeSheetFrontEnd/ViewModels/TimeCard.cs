using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSheetFrontEnd.Models;

namespace TimeSheetFrontEnd.ViewModels
{
	public class TimeCard
	{
		public List<Employee> Employees { get; set; }
		public List<Shift> Shifts { get; set; }
		public TimeCard() : this(null, null)
		{

		}
		public TimeCard(List<Employee> employee, List<Shift> shifts)
		{
			Employees = employee;
			Shifts = shifts;
		}
		public void DisplayCurrentCard(DateTime date)
		{ 
			
		}
	}
	
}