using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultSubscribeViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}