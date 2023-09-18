using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Todo>>> Get() {
            return Ok(await _todoService.GetTodos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> Get(int id) {
            var todo = await _todoService.GetTodoById(id);
            if (todo == null) {
                return NotFound();
            }
            return Ok(todo);
        }
    }
}