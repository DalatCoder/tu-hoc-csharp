using CommanderAPI.Models;
using System.Collections.Generic;

namespace CommanderAPI.Data
{
	public class MockCommanderRepo : ICommanderRepo
	{
		public void CreateCommand(Command cmd)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<Command> GetAllCommands()
		{
			var commands = new List<Command>()
			{
				new Command() { Id = 0, HowTo = "Boil an egg", Line = "boil water", Platform = "Windows" },
				new Command() { Id = 1, HowTo = "Cut bread", Line = "get a knife", Platform = "Windows" },
				new Command() { Id = 2, HowTo = "Make cup of tea", Line = "place teabag on cup", Platform = "Windows" }
			};

			return commands;
		}

		public Command GetCommandById(int id)
		{
			return new Command() { Id = 0, HowTo = "Boil an egg", Line = "boil water", Platform = "Windows" };
		}

		public bool SaveChanges()
		{
			throw new System.NotImplementedException();
		}
	}
}
