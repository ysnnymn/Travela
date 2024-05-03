using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Travela.WebUI.Dtos.DestinationDtos;

namespace Travela.WebUI.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DestinationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> DestinationList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7136/api/Destinations");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDestinationDto>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateDestination()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDestination(CreateDestinationDto createDestinationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createDestinationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7136/api/Destinations", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("DestinationList");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateDestination(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7136/api/Destinations/GetDestination?id="+id);
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateDestinationDto>(jsonData);
            return View(values);

        }
        [HttpPost]
        public async Task<IActionResult> UpdateDestination(UpdateDestinationDto updateDestinationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateDestinationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PutAsync("https://localhost:7136/api/Destinations", stringContent);
            return RedirectToAction("DestinationList");
        }
       
        public async Task<IActionResult> DeleteDestination(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.DeleteAsync("https://localhost:7136/api/Destinations?id="+id);
            return RedirectToAction("DestinationList");
        }
    }
}
