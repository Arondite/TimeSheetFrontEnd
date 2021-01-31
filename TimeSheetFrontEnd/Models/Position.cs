using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeSheetFrontEnd.Models
{
	public class Position
	{
		[Key]
		public int PositionId { get; set; }
		/// <summary>
		/// The square brackets limits the length of the string
		/// </summary>
		[StringLength(50)]
		public string Description { get; set; }
		/// <summary>
		/// This is the many relationship in the database. ICollection has many employees. Employee is the T value
		/// </summary>
		public virtual ICollection<Employee> Employees { get; set; }
	}
}
