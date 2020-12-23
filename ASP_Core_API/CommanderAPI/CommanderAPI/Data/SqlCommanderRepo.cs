using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
	public class SqlCommanderRepo : ICommanderRepo
	{
		private readonly CommaderContext _context;

		public SqlCommanderRepo(CommaderContext context)
		{
			_context = context;
		}

		public void CreateCommand(Command cmd)
		{
			if (cmd == null) throw new ArgumentNullException(nameof(cmd));

			_context.Commands.Add(cmd);
		}

		public IEnumerable<Command> GetAllCommands()
		{
			return _context.Commands.ToList();
		}

		public Command GetCommandById(int id)
		{
			return _context.Commands.FirstOrDefault(p => p.Id == id);
		}

		public bool SaveChanges()
		{
			return (_context.SaveChanges() >= 0);
		}
	}
}
