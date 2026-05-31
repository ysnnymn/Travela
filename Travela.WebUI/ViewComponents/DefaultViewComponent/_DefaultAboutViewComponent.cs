using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultAboutViewComponent:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultAboutViewComponent( IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
        
    }

    public async Task< IViewComponentResult> InvokeAsync()
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