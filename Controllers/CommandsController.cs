using Microsoft.RestWithASPNet.Mvc;
using System.Collections.Generic;
using RestWithASPNet.Models;
using RestWithASPNet.Data;
namespace RestWithASPNet.Data
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }
        //GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult <CommandsController> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById)id;
            return Ok(commandItem);
        }
    }
}