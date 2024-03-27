using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ToDoList.EntityLayer.Concrete;
using ToDoListUI.Dtos.CompletedTaskDto;
using ToDoListUI.Dtos.TaskDto;

namespace ToDoListUI.Controllers
{
    public class CompletedTaskController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CompletedTaskController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task< IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5067/api/CompletedTask");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<ResultTaskDto>>(jsonData);
                return View(values);
            }
            return View();
        }
                                     
        public async Task<IActionResult> DeleteCompletedTask(int id)
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5067/api/CompletedTask/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
