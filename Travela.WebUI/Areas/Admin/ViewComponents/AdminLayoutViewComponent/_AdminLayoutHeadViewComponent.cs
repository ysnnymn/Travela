using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponent;

public class _AdminLayoutHeadViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}