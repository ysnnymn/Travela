using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> AboutList()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7002/api/Abouts");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<About>>(jsonData);
                return View(values.FirstOrDefault());
            }
            
            return View();
        }

    }
}
