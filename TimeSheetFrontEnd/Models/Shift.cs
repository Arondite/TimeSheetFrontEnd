using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeSheetFrontEnd.Models
{
	public class Shift
	{
		[Key]
		public int ShiftId { get; set; }
		/// <summary>
		/// Datetime is a type of variable that is used in SQL
		/// </summary>
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
		public DateTime DateOfShift { get; set; }
		public string Employee { get; set; }
		/// <summary>
		/// This is the foreign key to the entity table
		/// </summary>
		public virtual Employee UserId { get; set; }
	}
}
