using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Models
{
	public class Command
	{
		public int ID { get; set; }
		public String HowTo { get; set; }
		public String Line { get; set; }
		public String Platform { get; set; }	
	}
}
