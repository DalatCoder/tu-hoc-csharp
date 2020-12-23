using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Dtos
{
	// We dont't expose Platform property to API client
	public class CommandReadDto
	{
		public int Id { get; set; }

		public String HowTo { get; set; }

		public String Line { get; set; }
	}
}
