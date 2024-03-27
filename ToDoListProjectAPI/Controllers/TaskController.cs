using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.BusinessLayer.Abstract;

namespace ToDoListProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        [HttpGet]
        public IActionResult TaskList()
        
        {
            var values = _taskService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTask(ToDoList.EntityLayer.Concrete.Task Task)
        {
            _taskService.TUpdate(Task);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var value = _taskService.TGetByID(id);
            _taskService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTask(ToDoList.EntityLayer.Concrete.Task Task)
        {
            _taskService.TUpdate(Task);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var value = _taskService.TGetByID(id);
            return Ok(value);
        }
    }
}
