using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TimeSheetFrontEnd.Models
{
	public class EmployeeLogin
	{
		[Key]
		public int PersonalId { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Privalege { get; set; }
	}
}