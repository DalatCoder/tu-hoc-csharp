﻿using AutoMapper;
using CommanderAPI.Data;
using CommanderAPI.Dtos;
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
		private readonly ICommanderRepo _repository;
		private readonly IMapper _mapper;

		public CommandsController(ICommanderRepo repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		//private readonly MockCommanderRepo _repository = new MockCommanderRepo();

		[HttpGet]
		public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
		{
			var commandItems = _repository.GetAllCommands();

			return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
		}

		// api/commands/{id}
		[HttpGet("{id}")]
		public ActionResult<CommandReadDto> GetCommandById(int id)
		{
			// id come from {id} in route
			var commandItem = _repository.GetCommandById(id);

			if (commandItem != null)
				return Ok(_mapper.Map<CommandReadDto>(commandItem));

			return NotFound();
		}
	}
}
