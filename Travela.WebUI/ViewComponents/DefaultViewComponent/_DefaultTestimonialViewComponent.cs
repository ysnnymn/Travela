using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents.DefaultViewComponent;

public class _DefaultTestimonialViewComponent:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
    
}