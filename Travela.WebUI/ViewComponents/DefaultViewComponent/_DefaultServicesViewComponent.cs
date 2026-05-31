using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Newtonsoft.Json;
using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultServicesViewComponent:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultServicesViewComponent(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task< IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var response = await client.GetAsync("https://localhost:7002/api/Services");
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Service>>(jsonData);
            
            values = values
                .OrderBy(x => Guid.NewGuid())
                .ToList();

            ViewBag.LeftServices = values.Take(4).ToList();
            ViewBag.RightServices = values.Skip(4).Take(4).ToList();
           
        }
        
        return View();
    }
    
}