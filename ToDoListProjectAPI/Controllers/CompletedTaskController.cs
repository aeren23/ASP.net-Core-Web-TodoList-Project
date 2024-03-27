using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.BusinessLayer.Abstract;
using ToDoList.EntityLayer.Concrete;

namespace ToDoListProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompletedTaskController : ControllerBase
    {
        private readonly ICompletedTaskService _completedTaskService;
        public CompletedTaskController(ICompletedTaskService completedTaskService)
        {
            _completedTaskService = completedTaskService;
        }
        [HttpGet]
        public IActionResult CompletedTaskList()
        {
            var values = _completedTaskService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCompletedTask(CompletedTask completedTask)
        {
            _completedTaskService.TUpdate(completedTask);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCompletedTask(int id)
        {
            var value = _completedTaskService.TGetByID(id);
            _completedTaskService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCompletedTask(CompletedTask completedTask)
        {
            _completedTaskService.TUpdate(completedTask);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCompletedTask(int id)
        {
            var value = _completedTaskService.TGetByID(id);
            return Ok(value);
        }
    }
}
