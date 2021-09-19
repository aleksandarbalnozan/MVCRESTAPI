using System.Collections.Generic;
using CVPorject1.Data;
using CVPorject1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CVPorject1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    class CommandController : ControllerBase
    {
        private readonly ICommanderRepo commanderRepo;

        public CommandController(ICommanderRepo _commanderRepo)
        {
            commanderRepo = _commanderRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            return Ok(commanderRepo.GetCommands());
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            return Ok(commanderRepo.GetCommandById(id));
        }

        
    }
}