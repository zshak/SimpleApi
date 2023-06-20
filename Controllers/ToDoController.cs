using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleApi.Models;
using simpleApi.Services;

namespace simpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;
        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_toDoService.GetList());
        }

        [HttpPost]
        public IActionResult CreateToDo(ToDo toDo)
        {
            _toDoService.CreateToDo(toDo);
            return Ok();
        }

        [HttpGet ("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_toDoService.GetById(id));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id)
        {
            _toDoService.UpdateById(id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _toDoService.DeleteById(id);
            return Ok();
        }
    }
}
