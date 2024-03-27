using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using ToDoListUI.Dtos.CompletedTaskDto;
using ToDoListUI.Dtos.TaskDto;

namespace ToDoListUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5067/api/Task");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTaskDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteTask(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5067/api/Task/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> CompleteTask(ResultTaskDto resultTaskDto)
        {
            CreateCompletedTaskDto completedTask = new CreateCompletedTaskDto
            {
                Content = resultTaskDto.Content,
                DateCompleted = DateTime.Parse(DateTime.Now.ToShortDateString())
            };

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(completedTask);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5067/api/CompletedTask", stringContent);

            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.DeleteAsync($"http://localhost:5067/api/Task/{resultTaskDto.ID}");
            if (responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(CreateTaskDto createTaskDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createTaskDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5067/api/Task", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        

    }
}
