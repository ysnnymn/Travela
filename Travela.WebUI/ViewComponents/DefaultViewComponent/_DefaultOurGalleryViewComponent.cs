using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultOurGalleryViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}