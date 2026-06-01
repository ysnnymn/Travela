using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponent;

public class _AdminLayoutScriptViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}