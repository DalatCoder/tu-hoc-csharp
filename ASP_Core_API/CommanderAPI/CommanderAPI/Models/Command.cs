using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Models
{
	public class Command
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(250)]
		public String HowTo { get; set; }

		[Required]
		public String Line { get; set; }

		[Required]
		public String Platform { get; set; }	
	}
}
