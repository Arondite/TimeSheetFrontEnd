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
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public DateTime Date { get; set; }
		/// <summary>
		/// This is the foreign key to the entity table
		/// </summary>
		public virtual Employee UserId { get; set; }
	}
}
