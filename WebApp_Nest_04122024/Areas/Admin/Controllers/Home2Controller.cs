using Microsoft.AspNetCore.Mvc;

namespace WebApp_Nest_04122024.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
