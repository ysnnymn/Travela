using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponent;

public class _AdminLayoutFooterViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}