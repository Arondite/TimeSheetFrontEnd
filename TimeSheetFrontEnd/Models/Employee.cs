using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeSheetFrontEnd.Models
{
	public class Employee
	{
		//The way I named the attributes is called Pascal Casing
		[Key]
		public int EmployeeId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int StoreNumber { get; set; }
		public string Username { get; set; }
		/// <summary>
		/// ? => can be null in database. Initially no-one will have a password
		/// </summary>
		public string Password { get; set; }
		public string Privilege { get; set; }
		public virtual Position position { get; set; }
	}
}
