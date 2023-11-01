using Microsoft.AspNetCore.Mvc;

namespace JEIFinalPro.Areas.Adminstrator.Controllers
{
    [Area("Adminstrator")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
