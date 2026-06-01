using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travela.WebUI.Dtos.StaticticDto;

namespace Travela.WebUI.Controllers
{
    public class StaticticController : Controller
    {
        private readonly IHttpClientFactory _clientFactory;

        public StaticticController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        // GET: StatisticController
        public async  Task<IActionResult> StatisticList()
        {
            var client = _clientFactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7002/api/Statictics");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var value=JsonConvert.DeserializeObject<ResultStaticticDto>(jsonData);
              
               
                return View(value);

            }
            return View();
        }

    }
}
