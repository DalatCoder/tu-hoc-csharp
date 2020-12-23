using CommanderAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
	public class CommaderContext : DbContext
	{
		public CommaderContext(DbContextOptions<CommaderContext> options) : base (options)
		{

		}

		public DbSet<Command> Commands { get; set; }
	}
}
