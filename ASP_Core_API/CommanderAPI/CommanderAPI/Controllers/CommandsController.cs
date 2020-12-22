using CommanderAPI.Data;
using CommanderAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Controllers
{
	[Route("api/commands")]
	[ApiController]
	public class CommandsController : ControllerBase
	{
		private readonly MockCommanderRepo _repository = new MockCommanderRepo();

		[HttpGet]
		public ActionResult<IEnumerable<Command>> GetAllCommands()
		{
			var commandItems = _repository.GetAppCommands();

			return Ok(commandItems);
		}

		// api/commands/{id}
		[HttpGet("{id}")]
		public ActionResult<Command> GetCommandById(int id)
		{
			// id come from {id} in route
			var commandItem = _repository.GetCommandById(id);
			return Ok(commandItem);
		}
	}
}
