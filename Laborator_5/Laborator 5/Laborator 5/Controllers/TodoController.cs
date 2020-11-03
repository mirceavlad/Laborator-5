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
        private readonly DataContext context;
        public TodoController (DataContext contex)
        {
            this.context = contex;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> Get()
        {
            return context.Todos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> Get(int id)
        {
            return context.Todos.Find(id);
        }

        [Route("/active")]
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetActive()
        {
            return context.Todos.Where(td => td.IsDone == false).ToList();
        }

        [Route("/done")]
        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetDone()
        {
            return context.Todos.Where(td => td.IsDone == true).ToList();
        }

    }

    
}
