using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodosWebAPI.Data;
using TodosWebAPI.Models;

namespace TodosWebAP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodosService todosService;

        public TodosController(ITodosService todosService)
        {
            this.todosService = todosService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> 
            GetTodos([FromQuery] int? userId, [FromQuery] bool? isCompleted) {
            try {
                IList<Todo> todos = await todosService.GetTodosAsync();
                return Ok(todos);
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteTodo([FromRoute] int id) {
            try {
                await todosService.RemoveTodoAsync(id);
                return Ok();
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Todo>> AddTodo([FromBody] Todo todo) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try {
                Todo added = await todosService.AddTodoAsync(todo);
                return Created($"/{added.TodoId}",added); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Todo>> UpdateTodo([FromBody] Todo todo) {
            try {
                Todo updatedTodo = await todosService.UpdateAsync(todo);
                return Ok(updatedTodo); 
            } catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
    }
}