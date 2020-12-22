using CommanderAPI.Models;
using System.Collections.Generic;

namespace CommanderAPI.Data
{
	public class MockCommanderRepo : ICommanderRepo
	{
		public IEnumerable<Command> GetAppCommands()
		{
			var commands = new List<Command>()
			{
				new Command() { ID = 0, HowTo = "Boil an egg", Line = "boil water", Platform = "Windows" },
				new Command() { ID = 1, HowTo = "Cut bread", Line = "get a knife", Platform = "Windows" },
				new Command() { ID = 2, HowTo = "Make cup of tea", Line = "place teabag on cup", Platform = "Windows" }
			};

			return commands;
		}

		public Command GetCommandById(int id)
		{
			return new Command() { ID = 0, HowTo = "Boil an egg", Line = "boil water", Platform = "Windows" };
		}
	}
}
