using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}