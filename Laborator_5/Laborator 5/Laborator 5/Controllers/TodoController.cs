using Laborator_5.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Laborator_5.Data;
using System.Linq;

namespace Laborator_5.Controllers
{
    [ApiController]
    [Route("todo")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _repository;
        public TodoController (TodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Todo>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}")]
        public ActionResult<Todo> Get(int id) => _repository.GetById(id);

        [Route("/active")]
        [HttpGet]
        public ActionResult<List<Todo>> GetActive() => _repository.GetActive().ToList();

        [Route("/done")]
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetDone() => _repository.GetDone().ToList();

    }

    
}
