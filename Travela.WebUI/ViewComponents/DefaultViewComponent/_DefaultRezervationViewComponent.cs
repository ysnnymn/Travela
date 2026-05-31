using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultRezervationViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}