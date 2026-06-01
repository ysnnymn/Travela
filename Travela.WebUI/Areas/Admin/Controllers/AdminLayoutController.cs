using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayoutController
        public ActionResult Index()
        {
            return View();
        }

    }
}
